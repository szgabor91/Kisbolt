namespace Kisbolt
{
    partial class VasarlasForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.termekListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mennyisegNum = new System.Windows.Forms.NumericUpDown();
            this.felvitelBtn = new System.Windows.Forms.Button();
            this.termekKategoriaCombo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.termekNevTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.vasarlasTetelekListView = new System.Windows.Forms.ListView();
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.vegosszegLabel = new System.Windows.Forms.Label();
            this.vasarlasBtn = new System.Windows.Forms.Button();
            this.vevoHozzaadasBtn = new System.Windows.Forms.Button();
            this.vevoAdatokListView = new System.Windows.Forms.ListView();
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mennyisegNum)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(321, 101);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Termék kiválasztása";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(349, 438);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mennyiség";
            // 
            // termekListView
            // 
            this.termekListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.termekListView.FullRowSelect = true;
            this.termekListView.HideSelection = false;
            this.termekListView.Location = new System.Drawing.Point(16, 138);
            this.termekListView.Margin = new System.Windows.Forms.Padding(4);
            this.termekListView.Name = "termekListView";
            this.termekListView.Size = new System.Drawing.Size(744, 276);
            this.termekListView.TabIndex = 8;
            this.termekListView.UseCompatibleStateImageBehavior = false;
            this.termekListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Termék azonosító";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Terméknév";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Kategória";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Ár";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Egység";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 80;
            // 
            // mennyisegNum
            // 
            this.mennyisegNum.Location = new System.Drawing.Point(291, 473);
            this.mennyisegNum.Margin = new System.Windows.Forms.Padding(4);
            this.mennyisegNum.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.mennyisegNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.mennyisegNum.Name = "mennyisegNum";
            this.mennyisegNum.Size = new System.Drawing.Size(193, 22);
            this.mennyisegNum.TabIndex = 9;
            this.mennyisegNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // felvitelBtn
            // 
            this.felvitelBtn.Location = new System.Drawing.Point(291, 517);
            this.felvitelBtn.Margin = new System.Windows.Forms.Padding(4);
            this.felvitelBtn.Name = "felvitelBtn";
            this.felvitelBtn.Size = new System.Drawing.Size(193, 28);
            this.felvitelBtn.TabIndex = 10;
            this.felvitelBtn.Text = "Felvitel";
            this.felvitelBtn.UseVisualStyleBackColor = true;
            this.felvitelBtn.Click += new System.EventHandler(this.felvitelBtn_Click);
            // 
            // termekKategoriaCombo
            // 
            this.termekKategoriaCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.termekKategoriaCombo.FormattingEnabled = true;
            this.termekKategoriaCombo.Location = new System.Drawing.Point(40, 62);
            this.termekKategoriaCombo.Margin = new System.Windows.Forms.Padding(4);
            this.termekKategoriaCombo.Name = "termekKategoriaCombo";
            this.termekKategoriaCombo.Size = new System.Drawing.Size(196, 24);
            this.termekKategoriaCombo.TabIndex = 11;
            this.termekKategoriaCombo.SelectedIndexChanged += new System.EventHandler(this.termekKategoriaCombo_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 28);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Termékkategória";
            // 
            // termekNevTxt
            // 
            this.termekNevTxt.Location = new System.Drawing.Point(263, 62);
            this.termekNevTxt.Margin = new System.Windows.Forms.Padding(4);
            this.termekNevTxt.Name = "termekNevTxt";
            this.termekNevTxt.Size = new System.Drawing.Size(259, 22);
            this.termekNevTxt.TabIndex = 13;
            this.termekNevTxt.KeyUp += new System.Windows.Forms.KeyEventHandler(this.termekNevTxt_KeyUp);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(367, 28);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Terméknév";
            // 
            // vasarlasTetelekListView
            // 
            this.vasarlasTetelekListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader9,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.vasarlasTetelekListView.FullRowSelect = true;
            this.vasarlasTetelekListView.HideSelection = false;
            this.vasarlasTetelekListView.Location = new System.Drawing.Point(811, 140);
            this.vasarlasTetelekListView.Margin = new System.Windows.Forms.Padding(4);
            this.vasarlasTetelekListView.Name = "vasarlasTetelekListView";
            this.vasarlasTetelekListView.Size = new System.Drawing.Size(639, 274);
            this.vasarlasTetelekListView.TabIndex = 16;
            this.vasarlasTetelekListView.UseCompatibleStateImageBehavior = false;
            this.vasarlasTetelekListView.View = System.Windows.Forms.View.Details;
            this.vasarlasTetelekListView.DoubleClick += new System.EventHandler(this.vasarlasTetelekListView_DoubleClick);
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Termék ID";
            this.columnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader9.Width = 86;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Terméknév";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 100;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Mennyiség";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader7.Width = 100;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Részösszeg";
            this.columnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader8.Width = 100;
            // 
            // vegosszegLabel
            // 
            this.vegosszegLabel.AutoSize = true;
            this.vegosszegLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.vegosszegLabel.Location = new System.Drawing.Point(1064, 512);
            this.vegosszegLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.vegosszegLabel.Name = "vegosszegLabel";
            this.vegosszegLabel.Size = new System.Drawing.Size(144, 31);
            this.vegosszegLabel.TabIndex = 17;
            this.vegosszegLabel.Text = "Összesen:";
            this.vegosszegLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // vasarlasBtn
            // 
            this.vasarlasBtn.Location = new System.Drawing.Point(1029, 442);
            this.vasarlasBtn.Margin = new System.Windows.Forms.Padding(4);
            this.vasarlasBtn.Name = "vasarlasBtn";
            this.vasarlasBtn.Size = new System.Drawing.Size(193, 28);
            this.vasarlasBtn.TabIndex = 18;
            this.vasarlasBtn.Text = "Vásárlás";
            this.vasarlasBtn.UseVisualStyleBackColor = true;
            this.vasarlasBtn.Click += new System.EventHandler(this.vasarlasBtn_Click);
            // 
            // vevoHozzaadasBtn
            // 
            this.vevoHozzaadasBtn.Location = new System.Drawing.Point(548, 58);
            this.vevoHozzaadasBtn.Margin = new System.Windows.Forms.Padding(4);
            this.vevoHozzaadasBtn.Name = "vevoHozzaadasBtn";
            this.vevoHozzaadasBtn.Size = new System.Drawing.Size(213, 28);
            this.vevoHozzaadasBtn.TabIndex = 19;
            this.vevoHozzaadasBtn.Text = "Vevő hozzáadása";
            this.vevoHozzaadasBtn.UseVisualStyleBackColor = true;
            this.vevoHozzaadasBtn.Click += new System.EventHandler(this.vevoHozzaadasBtn_Click);
            // 
            // vevoAdatokListView
            // 
            this.vevoAdatokListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13});
            this.vevoAdatokListView.Enabled = false;
            this.vevoAdatokListView.FullRowSelect = true;
            this.vevoAdatokListView.HideSelection = false;
            this.vevoAdatokListView.Location = new System.Drawing.Point(811, 58);
            this.vevoAdatokListView.Margin = new System.Windows.Forms.Padding(4);
            this.vevoAdatokListView.Name = "vevoAdatokListView";
            this.vevoAdatokListView.Size = new System.Drawing.Size(639, 74);
            this.vevoAdatokListView.TabIndex = 20;
            this.vevoAdatokListView.UseCompatibleStateImageBehavior = false;
            this.vevoAdatokListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Vevő ID";
            this.columnHeader10.Width = 80;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Vevő név/cégnév";
            this.columnHeader11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader11.Width = 120;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Vevő cégforma";
            this.columnHeader12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader12.Width = 150;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Vevő adószám";
            this.columnHeader13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader13.Width = 120;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1035, 20);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(181, 17);
            this.label5.TabIndex = 21;
            this.label5.Text = "Vevő adatai (nem kötelező)";
            // 
            // VasarlasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1479, 647);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.vevoAdatokListView);
            this.Controls.Add(this.vevoHozzaadasBtn);
            this.Controls.Add(this.vasarlasBtn);
            this.Controls.Add(this.vegosszegLabel);
            this.Controls.Add(this.vasarlasTetelekListView);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.termekNevTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.termekKategoriaCombo);
            this.Controls.Add(this.felvitelBtn);
            this.Controls.Add(this.mennyisegNum);
            this.Controls.Add(this.termekListView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "VasarlasForm";
            this.Text = "VasarlasForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VasarlasForm_FormClosing);
            this.Load += new System.EventHandler(this.VasarlasForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mennyisegNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView termekListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.NumericUpDown mennyisegNum;
        private System.Windows.Forms.Button felvitelBtn;
        private System.Windows.Forms.ComboBox termekKategoriaCombo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox termekNevTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView vasarlasTetelekListView;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Label vegosszegLabel;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.Button vasarlasBtn;
        private System.Windows.Forms.Button vevoHozzaadasBtn;
        private System.Windows.Forms.ListView vevoAdatokListView;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.Label label5;
    }
}