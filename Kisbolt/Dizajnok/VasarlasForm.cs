using Kisbolt.Dizajnok;
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


namespace Kisbolt
{
    public partial class VasarlasForm : Form
    {
        Dictionary<string, int> kategoriaIDk = new Dictionary<string, int>();
        VasarlasKezelo vk = new VasarlasKezelo();
        List<Termek> termekLista = new List<Termek>();
        List<Vasarlas> vasarlasLista = new List<Vasarlas>();
        int vegosszeg = 0;
        public static int vevoID = 0;

        public VasarlasForm()
        {
            InitializeComponent();
        }

        private string KategoriaNev(int kategoriaID)
        {
            string kategoriaNev = "";

            foreach (KeyValuePair<string, int> item in kategoriaIDk)
            {
                if (item.Value == kategoriaID)
                {
                    kategoriaNev = item.Key;
                    break;
                }
            }

            return kategoriaNev;
        }

        protected void KategoriaMegjelen()
        {
            List<TermekKategoria> kategoriaLista = vk.KategoriaLista();
            termekKategoriaCombo.Items.Add("");

            foreach (TermekKategoria item in kategoriaLista)
            {
                termekKategoriaCombo.Items.Add(item.kategoriaNev);
                if (!kategoriaIDk.ContainsKey(item.kategoriaNev))
                {
                    kategoriaIDk.Add(item.kategoriaNev, item.kategoriaID);
                }
            }
        }

        private void TermekMegjelen()
        {
            termekListView.Items.Clear();
            
            foreach (Termek item in termekLista)
            {
                ListViewItem lwi = new ListViewItem(item.termekID.ToString());
                lwi.SubItems.Add(item.termekNev);
                lwi.SubItems.Add(KategoriaNev(item.kategoriaID));
                lwi.SubItems.Add(item.ar.ToString());
                lwi.SubItems.Add(item.egyseg);
                termekListView.Items.Add(lwi);
            }
        }

        private void VevoAdatok(object sender, VevoEventArgs e)
        {
            vevoAdatokListView.Items.Clear();

            Vevo vevo = vk.VevoAdatok(vevoID);

            ListViewItem lwi = new ListViewItem(vevo.vevoID.ToString());
            lwi.SubItems.Add(vevo.vevoNev);
            lwi.SubItems.Add(vevo.vt.nev);
            lwi.SubItems.Add(vevo.adoszam);

            vevoAdatokListView.Items.Add(lwi);
        }

        private void Kereses()
        {
            int kategoriaID = termekKategoriaCombo.Text != "" ?
                kategoriaIDk[termekKategoriaCombo.Text] : 0;

            string termekNev = termekNevTxt.Text;

            termekLista = vk.TermekKereses(kategoriaID, termekNev);

            TermekMegjelen();
        }

        private void termekKategoriaCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Kereses();
        }

        private void termekNevTxt_KeyUp(object sender, KeyEventArgs e)
        {
            Kereses();
        }

        private void VasarlasForm_Load(object sender, EventArgs e)
        {
            termekLista = vk.TermekKereses();
            KategoriaMegjelen();
            TermekMegjelen();
        }

        private void felvitelBtn_Click(object sender, EventArgs e)
        {
            
            if(termekListView.SelectedItems.Count == 1)
            {
                int termekID = int.Parse(termekListView.SelectedItems[0].SubItems[0].Text);
                int mennyiseg = (int) mennyisegNum.Value;

                if(mennyiseg == 0)
                {
                    MessageBox.Show("A mennyiség nem lehet nulla!");
                    return;
                }

                string termekNev = termekListView.SelectedItems[0].SubItems[1].Text;
                int ar = int.Parse(termekListView.SelectedItems[0].SubItems[3].Text);
                int reszosszeg = ar * mennyiseg;
                vegosszeg += reszosszeg;
                vegosszegLabel.Text = "Összesen: " + vegosszeg + " Ft";

                ListViewItem lwi = new ListViewItem(termekID.ToString());
                lwi.SubItems.Add(termekNev);
                lwi.SubItems.Add(mennyiseg.ToString());
                lwi.SubItems.Add(reszosszeg.ToString());
                vasarlasTetelekListView.Items.Add(lwi);

                Vasarlas vasarlas = new Vasarlas(termekID, mennyiseg);
                vasarlasLista.Add(vasarlas);
            }
        }

        private void vasarlasBtn_Click(object sender, EventArgs e)
        {
            List<Vasarlas> vasarlasLista = new List<Vasarlas>();
            foreach (ListViewItem lwi in vasarlasTetelekListView.Items)
            {
                int termekID = int.Parse(lwi.SubItems[0].Text);
                int mennyiseg = int.Parse(lwi.SubItems[2].Text);

                Vasarlas vasarlas = new Vasarlas(termekID, mennyiseg);
                vasarlasLista.Add(vasarlas);
            }

            if(vasarlasLista.Count != 0)
            {
                vk.EllenorzottFelvitel(vasarlasLista, vevoID);
                vasarlasTetelekListView.Items.Clear();
                vegosszegLabel.Text = "";
                vegosszeg = 0;
                vevoID = 0;
                vevoAdatokListView.Items.Clear();
            }
            else
            {
                MessageBox.Show("Nincsenek tételek kiválasztva");
            }
        }

        private void vevoHozzaadasBtn_Click(object sender, EventArgs e)
        {
            VevoListaForm form = new VevoListaForm();
            form.ev += VevoAdatok;
            form.Show();
        }

        private void vasarlasTetelekListView_DoubleClick(object sender, EventArgs e)
        {
            int ar = int.Parse(vasarlasTetelekListView.SelectedItems[0].SubItems[3].Text);
            vegosszeg -= ar;
            vegosszegLabel.Text = "Összesen: " + vegosszeg + " Ft";
            vasarlasTetelekListView.SelectedItems[0].Remove();
        }

        private void VasarlasForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(vasarlasTetelekListView.Items.Count > 0)
            {
                DialogResult window = MessageBox.Show(
                "Nem fejezte be a vásárlást.",
                "Biztos ki szeretne lépni?",
                MessageBoxButtons.YesNo);

                e.Cancel = (window == DialogResult.No);
            }
        }
    }
}
