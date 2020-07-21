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
    public partial class RaktarForm : Form
    {
        int raktarID;
        RaktarKezelo rk = new RaktarKezelo();
        Dictionary<string, int> termekIDk = new Dictionary<string, int>();

        public RaktarForm()
        {
            InitializeComponent();
        }

        private void TermekekBetoltese()
        {
            List<Termek> termekLista = rk.TermekLista();

            foreach (Termek termek in termekLista)
            {
                if(!termekIDk.ContainsKey(termek.termekNev))
                {
                    termekIDk.Add(termek.termekNev, termek.termekID);
                }

                termekCombo.Items.Add(termek.termekNev);
            }
        }

        public void MezokAlaphelyzetbe()
        {
            termekCombo.SelectedIndex = 0;
            mennyisegNum.Value = 1;
            beszerzesiArNum.Value = 1;
        }

        public void RaktarBetoltes()
        {
            raktarListView.Items.Clear();
            List<Raktar> raktarLista = rk.RaktarLista();

            foreach (Raktar raktar in raktarLista)
            {
                ListViewItem lwi = new ListViewItem(
                    raktar.raktarID.ToString()    
                );

                lwi.SubItems.Add(raktar.termek.termekNev);
                lwi.SubItems.Add($"{raktar.mennyiseg} {raktar.termek.egyseg}");
                lwi.SubItems.Add(raktar.beszerzesiAr + " Ft.");
                lwi.SubItems.Add(raktar.beszerzesiIdopont.ToString("yyyy-mm-dd hh:mm:ss"));

                raktarListView.Items.Add(lwi);
            }
        }

        private void felvitenBtn_Click(object sender, EventArgs e)
        {
            int termekID = termekIDk.ContainsKey(termekCombo.Text) ?
                termekIDk[termekCombo.Text] : 0;

            Termek termek = rk.TermekAdatok(termekID);

            int mennyiseg = (int)mennyisegNum.Value;
            int beszerzesiAr = (int)beszerzesiArNum.Value;
            DateTime beszerzesiDatum = beszerzesDateTime.Value;
            Raktar raktar = new Raktar(
                termek, mennyiseg, 
                beszerzesiAr, beszerzesiDatum    
            );

            if(raktarID == 0)
            {
                try
                {
                    rk.EllenorzottFelvitel(raktar);
                    MezokAlaphelyzetbe();
                    RaktarBetoltes();
                } catch(ArgumentException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            } else
            {
                try
                {
                    raktar.raktarID = this.raktarID;
                    rk.EllenorzottFeluliras(raktar);
                    MezokAlaphelyzetbe();
                    RaktarBetoltes();
                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void RaktarForm_Load(object sender, EventArgs e)
        {
            TermekekBetoltese();
            RaktarBetoltes();
        }

        private void torlesBtn_Click(object sender, EventArgs e)
        {
            if(raktarListView.SelectedItems.Count > 0)
            {
                foreach (ListViewItem lwi in raktarListView.SelectedItems)
                {
                    int ID = int.Parse(lwi.SubItems[0].Text);
                    rk.RaktarTorles(ID);
                }

                RaktarBetoltes();
            } else
            {
                MessageBox.Show("A törléshez legalább egy sort ki kell jelölni!");
            }
        }

        private void raktarListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(raktarListView.SelectedItems.Count > 0)
            {
                this.raktarID = int.Parse(
                    raktarListView.SelectedItems[0].SubItems[0].Text
                );

                Raktar raktar = rk.RaktarAdatok(this.raktarID);
                termekCombo.Text = raktar.termek.termekNev;
                mennyisegNum.Value = raktar.mennyiseg;
                beszerzesiArNum.Value = raktar.beszerzesiAr;
                beszerzesDateTime.Value = raktar.beszerzesiIdopont;
                felvitenBtn.Text = "Felülírás";
            } else
            {
                MezokAlaphelyzetbe();
                this.raktarID = 0;
                felvitenBtn.Text = "Felvitel";
            }
        }

        private void RaktarForm_Click(object sender, EventArgs e)
        {
            this.raktarID = 0;
            felvitenBtn.Text = "Felvitel";
            MezokAlaphelyzetbe();
        }
    }
}
