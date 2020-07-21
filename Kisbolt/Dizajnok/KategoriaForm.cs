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
    public partial class KategoriaForm : Form
    {
        KategoriaKezelo kk = new KategoriaKezelo();
        int termekkategoriaID = 0;

        public KategoriaForm()
        {
            InitializeComponent();
        }

        private void MezokAlaphelyzetbe()
        {
            kategoriaText.Text = "";
        }

        private void KategoriaListazas()
        {
            kategoriaListView.Items.Clear();
            List<TermekKategoria> kategoriaLista = kk.KategoriaLista();

            foreach (TermekKategoria tk in kategoriaLista)
            {
                ListViewItem lwi = new ListViewItem(tk.kategoriaID.ToString());
                lwi.SubItems.Add(tk.kategoriaNev);
                kategoriaListView.Items.Add(lwi);
            }
        }

        private void felvitelBtn_Click(object sender, EventArgs e)
        {
            string kategoriaNev = kategoriaText.Text;
            TermekKategoria tk = new TermekKategoria(kategoriaNev);

            if(termekkategoriaID == 0)
            {
                try
                {
                    kk.Felvitel(tk);
                    KategoriaListazas();
                    MezokAlaphelyzetbe();
                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            } else
            {
                try
                {
                    tk.kategoriaID = termekkategoriaID;
                    kk.Feluliras(tk);
                    KategoriaListazas();
                    MezokAlaphelyzetbe();
                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            
        }

        private void KategoriaForm_Load(object sender, EventArgs e)
        {
            KategoriaListazas();
        }

        private void torlesBtn_Click(object sender, EventArgs e)
        {
            if(kategoriaListView.SelectedItems.Count > 0)
            {
                foreach (ListViewItem lwi in kategoriaListView.SelectedItems)
                {
                    int kategoriaID = int.Parse(lwi.SubItems[0].Text);
                    kk.KategoriaTorles(kategoriaID);
                }

                KategoriaListazas();
            } else
            {
                MessageBox.Show("A törléshez legalább egy elemet ki kell jelölni!");
            }
        }

        private void kategoriaListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(kategoriaListView.SelectedItems.Count > 0)
            {
                termekkategoriaID = int.Parse(kategoriaListView.SelectedItems[0].SubItems[0].Text);
                felvitelBtn.Text = "Felülírás";
                TermekKategoria tk = kk.Kategoria(termekkategoriaID);
                kategoriaText.Text = tk.kategoriaNev;
            } else
            {
                felvitelBtn.Text = "Felvitel";
                termekkategoriaID = 0;
                MezokAlaphelyzetbe();
            }
        }

        private void KategoriaForm_Click(object sender, EventArgs e)
        {
            felvitelBtn.Text = "Felvitel";
            termekkategoriaID = 0;
            MezokAlaphelyzetbe();
        }
    }
}
