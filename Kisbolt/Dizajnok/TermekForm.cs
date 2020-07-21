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
    public partial class TermekForm : Form
    {
        TermekKezelo tk = new TermekKezelo();
        protected Dictionary<string, int> kategoriaIDk = new Dictionary<string, int>();
        int termekID;

        public TermekForm()
        {
            InitializeComponent();
        }

        protected void KategoriaMegjelen()
        {
            List<TermekKategoria> kategoriaLista = tk.KategoriaLista();

            foreach (TermekKategoria item in kategoriaLista)
            {
                kategoriaCombo.Items.Add(item.kategoriaNev);
                if(!kategoriaIDk.ContainsKey(item.kategoriaNev))
                {
                    kategoriaIDk.Add(item.kategoriaNev, item.kategoriaID);
                }
            }
        }

        private string KategoriaNev(int kategoriaID)
        {
            string kategoriaNev = "";

            foreach (KeyValuePair<string, int> item in kategoriaIDk)
            {
                if(item.Value == kategoriaID)
                {
                    kategoriaNev = item.Key;
                    break;
                }
            }

            return kategoriaNev;
        }

        private void MezokAlaphelyzetbe()
        {
            termekNevText.Text = "";
            arNumeric.Value = 0;
            kategoriaCombo.Text = "";
            egysegCombo.Text = "";
        }

        private void TermekekekMegjelen()
        {
            termekListView.Items.Clear();
            List<Termek> termekLista = tk.TermekLista();

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

        private void TermekForm_Load(object sender, EventArgs e)
        {
            KategoriaMegjelen();
            TermekekekMegjelen();
        }

        private void felvitelBtn_Click(object sender, EventArgs e)
        {
            string termekNev = termekNevText.Text;
            int ar = (int)arNumeric.Value;
            int kategoriaID = kategoriaCombo.Text != "" 
                ? kategoriaIDk[kategoriaCombo.Text] : 0;
            string egyseg = egysegCombo.Text;
            Termek termek = new Termek(ar, kategoriaID, termekNev, egyseg);
            
            if(termekID == 0)
            {
                try
                {
                    tk.Felvitel(termek);
                    MezokAlaphelyzetbe();
                    TermekekekMegjelen();
                } catch(ArgumentException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            } else
            {
                termek.termekID = this.termekID;

                try
                {
                    tk.Feluliras(termek);
                    MezokAlaphelyzetbe();
                    TermekekekMegjelen();
                } catch (ArgumentException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void termekListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (termekListView.SelectedItems.Count > 0)
            {
                this.termekID = int.Parse(termekListView.SelectedItems[0].SubItems[0].Text);
                Termek termek = tk.TermekAdatok(this.termekID);

                termekNevText.Text = termek.termekNev;
                arNumeric.Value = termek.ar;
                kategoriaCombo.Text = KategoriaNev(termek.kategoriaID);
                egysegCombo.Text = termek.egyseg;
                felvitelBtn.Text = "Felülírás";
            } else
            {
                this.termekID = 0;
                felvitelBtn.Text = "Felvitel";
                MezokAlaphelyzetbe();
            }
        }

        private void torlesBtn_Click(object sender, EventArgs e)
        {
            if(termekListView.SelectedItems.Count > 0)
            {
                foreach (ListViewItem lwi in termekListView.SelectedItems)
                {
                    int termekID = int.Parse(lwi.SubItems[0].Text);
                    tk.TermekTorles(termekID);
                }

                TermekekekMegjelen();
            }
            else
            {
                MessageBox.Show("A törléshez ki kell jelölni legalább egy terméket!");
            }
        }

        private void TermekForm_Click(object sender, EventArgs e)
        {
            this.termekID = 0;
            felvitelBtn.Text = "Felvitel";
            MezokAlaphelyzetbe();
        }
    }
}
