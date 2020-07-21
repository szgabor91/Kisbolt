using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kisbolt.Modellek;


namespace Kisbolt
{
    public partial class VevokForm : Form
    {
        VevoKezelo vk = new VevoKezelo();
        Dictionary<string, int> vevoTipusIDk = new Dictionary<string, int>();
        int vevoID = 0;

        public VevokForm()
        {
            InitializeComponent();
        }

        private void MezokAlaphelyzetbe()
        {
            vevoNevTxt.Text = "";
            vevoTipusCombo.SelectedIndex = 0;
            adoSzamTxt.Text = "";
            szekhelyTxt.Text = "";
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

        private void felvitelBtn_Click(object sender, EventArgs e)
        {
            string vevoNev = vevoNevTxt.Text;
            int vevoTipus = vevoTipusIDk.ContainsKey(vevoTipusCombo.Text) ?
                vevoTipusIDk[vevoTipusCombo.Text] : 0;
            VevoTipus vt = new VevoTipus();
            vt.tipus = vevoTipus;
            vt.nev = vevoTipusCombo.Text;

            string adoszam = adoSzamTxt.Text;
            string szekhely = szekhelyTxt.Text;

            Vevo vevo = new Vevo(vevoNev, vt, adoszam, szekhely, 1);

            if(vevoID == 0)
            {
                try
                {
                    vk.EllenorzottFelvitel(vevo);
                    MezokAlaphelyzetbe();
                    VevoLista();
                } catch(ArgumentException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            } else
            {
                try
                {
                    vevo.vevoID = vevoID;
                    vk.EllenorzottFeluliras(vevo);
                    MezokAlaphelyzetbe();
                    VevoLista();
                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
         
        private void VevoTipusLista()
        {
            List<VevoTipus> vevoTipusok = vk.VevoTipusLista();

            foreach (VevoTipus vt in vevoTipusok)
            {
                vevoTipusCombo.Items.Add(vt.nev);
                vevoTipusIDk.Add(vt.nev, vt.tipus);
            }
        }

        private void VevokForm_Load(object sender, EventArgs e)
        {
            VevoTipusLista();
            VevoLista();
        }

        private void passzivBtn_Click(object sender, EventArgs e)
        {
            if(vevokListView.SelectedItems.Count > 0)
            {
                foreach (ListViewItem lwi in vevokListView.SelectedItems)
                {
                    int ID = int.Parse(lwi.SubItems[0].Text);

                    vk.VevoStatusz(ID, 0);
                }

                VevoLista();
            }
            else
            {
                MessageBox.Show("Passzív állományba helyezéshez ki kell jelölni egy vevőt!");
            }
        }

        private void aktivBtn_Click(object sender, EventArgs e)
        {
            if (vevokListView.SelectedItems.Count > 0)
            {
                foreach (ListViewItem lwi in vevokListView.SelectedItems)
                {
                    int ID = int.Parse(lwi.SubItems[0].Text);

                    vk.VevoStatusz(ID, 1);
                }

                VevoLista();
            }
            else
            {
                MessageBox.Show("Aktív állományba helyezéshez ki kell jelölni egy vevőt!");
            }
        }

        private void vevokListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(vevokListView.SelectedItems.Count > 0)
            {
                vevoID = int.Parse(vevokListView.SelectedItems[0].SubItems[0].Text);

                Vevo vevo = vk.VevoAdatok(vevoID);

                vevoNevTxt.Text = vevo.vevoNev;
                vevoTipusCombo.Text = vevo.vt.nev;
                adoSzamTxt.Text = vevo.adoszam;
                szekhelyTxt.Text = vevo.szekhely;
                felvitelBtn.Text = "Felülírás";
            } else
            {
                vevoID = 0;
                MezokAlaphelyzetbe();
                felvitelBtn.Text = "Felvitel";
            }
        }

        private void VevokForm_Click(object sender, EventArgs e)
        {
            vevoID = 0;
            MezokAlaphelyzetbe();
            felvitelBtn.Text = "Felvitel";
        }
    }
}
