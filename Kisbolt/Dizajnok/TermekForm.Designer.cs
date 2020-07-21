namespace Kisbolt
{
    partial class TermekForm
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
            this.termekNevText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.kategoriaCombo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.felvitelBtn = new System.Windows.Forms.Button();
            this.termekListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.torlesBtn = new System.Windows.Forms.Button();
            this.arNumeric = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.egysegCombo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.arNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Terméknév";
            // 
            // termekNevText
            // 
            this.termekNevText.Location = new System.Drawing.Point(17, 74);
            this.termekNevText.Margin = new System.Windows.Forms.Padding(4);
            this.termekNevText.Name = "termekNevText";
            this.termekNevText.Size = new System.Drawing.Size(193, 22);
            this.termekNevText.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 117);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ár";
            // 
            // kategoriaCombo
            // 
            this.kategoriaCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kategoriaCombo.FormattingEnabled = true;
            this.kategoriaCombo.Location = new System.Drawing.Point(16, 293);
            this.kategoriaCombo.Margin = new System.Windows.Forms.Padding(4);
            this.kategoriaCombo.Name = "kategoriaCombo";
            this.kategoriaCombo.Size = new System.Drawing.Size(193, 24);
            this.kategoriaCombo.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 262);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Kategória";
            // 
            // felvitelBtn
            // 
            this.felvitelBtn.Location = new System.Drawing.Point(17, 346);
            this.felvitelBtn.Margin = new System.Windows.Forms.Padding(4);
            this.felvitelBtn.Name = "felvitelBtn";
            this.felvitelBtn.Size = new System.Drawing.Size(195, 28);
            this.felvitelBtn.TabIndex = 6;
            this.felvitelBtn.Text = "Felvitel";
            this.felvitelBtn.UseVisualStyleBackColor = true;
            this.felvitelBtn.Click += new System.EventHandler(this.felvitelBtn_Click);
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
            this.termekListView.Location = new System.Drawing.Point(305, 42);
            this.termekListView.Margin = new System.Windows.Forms.Padding(4);
            this.termekListView.Name = "termekListView";
            this.termekListView.Size = new System.Drawing.Size(744, 276);
            this.termekListView.TabIndex = 7;
            this.termekListView.UseCompatibleStateImageBehavior = false;
            this.termekListView.View = System.Windows.Forms.View.Details;
            this.termekListView.SelectedIndexChanged += new System.EventHandler(this.termekListView_SelectedIndexChanged);
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
            // torlesBtn
            // 
            this.torlesBtn.Location = new System.Drawing.Point(305, 346);
            this.torlesBtn.Margin = new System.Windows.Forms.Padding(4);
            this.torlesBtn.Name = "torlesBtn";
            this.torlesBtn.Size = new System.Drawing.Size(745, 28);
            this.torlesBtn.TabIndex = 8;
            this.torlesBtn.Text = "Törlés";
            this.torlesBtn.UseVisualStyleBackColor = true;
            this.torlesBtn.Click += new System.EventHandler(this.torlesBtn_Click);
            // 
            // arNumeric
            // 
            this.arNumeric.Location = new System.Drawing.Point(16, 146);
            this.arNumeric.Margin = new System.Windows.Forms.Padding(4);
            this.arNumeric.Maximum = new decimal(new int[] {
            200000000,
            0,
            0,
            0});
            this.arNumeric.Name = "arNumeric";
            this.arNumeric.Size = new System.Drawing.Size(196, 22);
            this.arNumeric.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(88, 185);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Egység";
            // 
            // egysegCombo
            // 
            this.egysegCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.egysegCombo.FormattingEnabled = true;
            this.egysegCombo.Items.AddRange(new object[] {
            "db",
            "kg",
            "dkg",
            "liter",
            "csomag"});
            this.egysegCombo.Location = new System.Drawing.Point(16, 215);
            this.egysegCombo.Margin = new System.Windows.Forms.Padding(4);
            this.egysegCombo.Name = "egysegCombo";
            this.egysegCombo.Size = new System.Drawing.Size(193, 24);
            this.egysegCombo.TabIndex = 10;
            // 
            // TermekForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 470);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.egysegCombo);
            this.Controls.Add(this.arNumeric);
            this.Controls.Add(this.torlesBtn);
            this.Controls.Add(this.termekListView);
            this.Controls.Add(this.felvitelBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.kategoriaCombo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.termekNevText);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TermekForm";
            this.Text = "TermekForm";
            this.Load += new System.EventHandler(this.TermekForm_Load);
            this.Click += new System.EventHandler(this.TermekForm_Click);
            ((System.ComponentModel.ISupportInitialize)(this.arNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox termekNevText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox kategoriaCombo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button felvitelBtn;
        private System.Windows.Forms.ListView termekListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button torlesBtn;
        private System.Windows.Forms.NumericUpDown arNumeric;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox egysegCombo;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}