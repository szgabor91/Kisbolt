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
using Kisbolt.Kivetelek;
using Kisbolt.Tipusok;

namespace Kisbolt
{
    public partial class Form1 : Form
    {
        AbKezelo ab = new AbKezelo();
        FelhasznaloKezelo fk = new FelhasznaloKezelo();

        public Form1()
        {
            InitializeComponent();
        }

        private void termékkategóriaFelviteleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!FelhasznaloKezelo.Autentikalt())
            {
                MessageBox.Show("A menüpont megnyitásához be kell lépnie!");
                return;
            }

            KategoriaForm form = new KategoriaForm();
            form.Show();
        }

        private void raktárKezeléseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!FelhasznaloKezelo.Autentikalt())
            {
                MessageBox.Show("A menüpont megnyitásához be kell lépnie!");
                return;

            }

            RaktarForm form = new RaktarForm();
            form.Show();
        }

        private void termékFelviteleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!FelhasznaloKezelo.Autentikalt())
            {
                MessageBox.Show("A menüpont megnyitásához be kell lépnie!");
                return;

            }

            TermekForm form = new TermekForm();
            form.Show();
        }

        private void vásárlásFelviteleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!FelhasznaloKezelo.Autentikalt())
            {
                MessageBox.Show("A menüpont megnyitásához be kell lépnie!");
                return;

            }

            VasarlasForm form = new VasarlasForm();
            form.Show();
        }

        private void vevőkFelviteleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!FelhasznaloKezelo.Autentikalt())
            {
                MessageBox.Show("A menüpont megnyitásához be kell lépnie!");
                return;

            }

            VevokForm form = new VevokForm();
            form.Show();
        }

        private void korábbiVásárlásokToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!FelhasznaloKezelo.Autentikalt())
            {
                MessageBox.Show("A menüpont megnyitásához be kell lépnie!");
                return;

            }

            KorabbiVasarlasok form = new KorabbiVasarlasok();
            form.Show();
        }

        private void belepesBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Cegadatok cegadatok = FelhasznaloKezelo.Beleptetes(ab, felhNevTxt.Text, jelszoTxt.Text);
                MessageBox.Show("Sikeres azonosítás!");
                felhNevTxt.Text = cegadatok.GetFelhNev();
                felhNevTxt.Enabled = false;
                felhNevTxt.TextAlign = HorizontalAlignment.Center;
                jelszoLabel.Text = "Cégnév";
                jelszoTxt.Text = cegadatok.GetCegnev() + " " + cegadatok.GetTipus();
                jelszoTxt.TextAlign = HorizontalAlignment.Center;                
                jelszoTxt.Enabled = false;
                jelszoTxt.PasswordChar = '\0';

                belepesBtn.Visible = false;
            }
            catch(AutentikacioKivetel ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                Hide();
                notifyIcon.Visible = true;
            }
            else
            {
                notifyIcon.Visible = false;
                Show();
            }
        }

        private void notifyIcon_DoubleClick(object sender, EventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon.Visible = false;
        }
    }
}
