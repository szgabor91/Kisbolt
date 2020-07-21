using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kisbolt.Esemenyek;
using Kisbolt.Modellek;


namespace Kisbolt.Dizajnok
{
    public partial class VevoListaForm : Form
    {
        VevoKezelo vk = new VevoKezelo();
        public delegate void VevoEvent(object sender, VevoEventArgs e);
        public event VevoEvent ev;

        public VevoListaForm()
        {
            InitializeComponent();
        }

        private void VevoLista()
        {
            vevokListView.Items.Clear();
            List<Vevo> vevoLista = vk.VevoLista();

            foreach (Vevo vevo in vevoLista)
            {
                ListViewItem lwi = new ListViewItem(vevo.vevoID.ToString());
                lwi.SubItems.Add(vevo.vevoNev);
                lwi.SubItems.Add(vevo.vt.nev);
                lwi.SubItems.Add(vevo.adoszam);
                lwi.SubItems.Add(vevo.szekhely);
                string aktiv = vevo.aktiv == 1 ? "aktív" : "passzív";
                lwi.SubItems.Add(aktiv);
                vevokListView.Items.Add(lwi);
            }
        }

        private void VevoListaForm_Load(object sender, EventArgs e)
        {
            VevoLista();
        }

        private void hozzaadasBtn_Click(object sender, EventArgs e)
        {
            if(vevokListView.SelectedItems.Count > 0)
            {
                VasarlasForm.vevoID = int.Parse(vevokListView.SelectedItems[0].SubItems[0].Text);

                if (ev != null)
                    ev(this, new VevoEventArgs("Sikeres hozzáadás!"));
                this.Close();
            } else
            {
                VasarlasForm.vevoID = 0;
            }
        }
    }
}
