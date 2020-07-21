using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kisbolt.Tipusok;
using Kisbolt.Modellek;


namespace Kisbolt
{
    public partial class KorabbiVasarlasok : Form
    {
        VasarlasKezelo vk = new VasarlasKezelo();
        int vasarlasID = 0;
        int vevoID = 0;

        public KorabbiVasarlasok()
        {
            InitializeComponent();
        }

        private void VasarlasokMegjelenitese()
        {
            vasarlasokListView.Items.Clear();
            List<VasarlasAlap> vasarlasok = vk.VasarlasLista();

            foreach (VasarlasAlap va in vasarlasok)
            {
                ListViewItem lwi = new ListViewItem(va.vasarlasID.ToString());
                lwi.SubItems.Add(va.vasarlasIdopont.ToString("yyyy-MM-dd hh:mm:ss"));
                lwi.SubItems.Add(va.vevoID.ToString());
                string sztorno = va.sztorno == 1 ? "igen" : "nem";
                lwi.SubItems.Add(sztorno);

                vasarlasokListView.Items.Add(lwi);
            }
        }

        private void VasarlasReszletek(int vasarlasID)
        {
            vasarlasTetelekListView.Items.Clear();
            List<Vasarlas> vasarlasTetelek = vk.VasarlasReszletek(vasarlasID);

            foreach(Vasarlas tetel in vasarlasTetelek)
            {
                ListViewItem lwi = new ListViewItem(tetel.tetelID.ToString());
                lwi.SubItems.Add(tetel.termekID.ToString());
                lwi.SubItems.Add(tetel.termekNev);
                lwi.SubItems.Add(tetel.mennyiseg.ToString());

                vasarlasTetelekListView.Items.Add(lwi);
            }
        }

        private void VevoAdatok(int vevoID)
        {
            vevoListView.Items.Clear();
            Vevo vevo = vk.VevoAdatok(vevoID);

            ListViewItem lwi = new ListViewItem(vevo.vevoID.ToString());
            lwi.SubItems.Add(vevo.vevoNev);
            lwi.SubItems.Add(vevo.vt.nev);
            lwi.SubItems.Add(vevo.adoszam);
            lwi.SubItems.Add(vevo.szekhely);
            string aktiv = vevo.aktiv == 1 ? "aktív" : "passzív";
            lwi.SubItems.Add(aktiv);
            vevoListView.Items.Add(lwi);
        }

        private void KorabbiVasarlasok_Load(object sender, EventArgs e)
        {
            VasarlasokMegjelenitese();
        }

        private void vasarlasokListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(vasarlasokListView.SelectedItems.Count > 0)
            {
                vasarlasID = int.Parse(vasarlasokListView.SelectedItems[0].SubItems[0].Text);
                vevoID = int.Parse(vasarlasokListView.SelectedItems[0].SubItems[2].Text);
                VasarlasReszletek(vasarlasID);
                VevoAdatok(vevoID);
            } else
            {
                vasarlasID = 0;
                vasarlasTetelekListView.Items.Clear();
                vevoListView.Items.Clear();
            }
        }

        private void sztornoBtn_Click(object sender, EventArgs e)
        {
            if (vasarlasID != 0)
            {
                vk.VasarlasSztorno(vasarlasID, 1);
                VasarlasokMegjelenitese();
            }
        }

        private void sztornoVisszaBtn_Click(object sender, EventArgs e)
        {
            if (vasarlasID != 0)
            {
                vk.VasarlasSztorno(vasarlasID, 0);
                VasarlasokMegjelenitese();
            }
        }
    }
}
