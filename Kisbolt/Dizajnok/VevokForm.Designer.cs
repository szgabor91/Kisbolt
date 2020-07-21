namespace Kisbolt
{
    partial class VevokForm
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
            this.vevoNevTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.vevoTipusCombo = new System.Windows.Forms.ComboBox();
            this.adoSzamTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.szekhelyTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.felvitelBtn = new System.Windows.Forms.Button();
            this.vevokListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.passzivBtn = new System.Windows.Forms.Button();
            this.aktivBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(189, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Név/Cégnév";
            // 
            // vevoNevTxt
            // 
            this.vevoNevTxt.Location = new System.Drawing.Point(149, 52);
            this.vevoNevTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.vevoNevTxt.Name = "vevoNevTxt";
            this.vevoNevTxt.Size = new System.Drawing.Size(169, 22);
            this.vevoNevTxt.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(193, 91);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Vevő típus";
            // 
            // vevoTipusCombo
            // 
            this.vevoTipusCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.vevoTipusCombo.FormattingEnabled = true;
            this.vevoTipusCombo.Location = new System.Drawing.Point(149, 122);
            this.vevoTipusCombo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.vevoTipusCombo.Name = "vevoTipusCombo";
            this.vevoTipusCombo.Size = new System.Drawing.Size(169, 24);
            this.vevoTipusCombo.TabIndex = 3;
            // 
            // adoSzamTxt
            // 
            this.adoSzamTxt.Location = new System.Drawing.Point(149, 191);
            this.adoSzamTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.adoSzamTxt.Name = "adoSzamTxt";
            this.adoSzamTxt.Size = new System.Drawing.Size(169, 22);
            this.adoSzamTxt.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(201, 166);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Adószám";
            // 
            // szekhelyTxt
            // 
            this.szekhelyTxt.Location = new System.Drawing.Point(16, 258);
            this.szekhelyTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.szekhelyTxt.Name = "szekhelyTxt";
            this.szekhelyTxt.Size = new System.Drawing.Size(429, 22);
            this.szekhelyTxt.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(201, 231);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Székhely";
            // 
            // felvitelBtn
            // 
            this.felvitelBtn.Location = new System.Drawing.Point(149, 302);
            this.felvitelBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.felvitelBtn.Name = "felvitelBtn";
            this.felvitelBtn.Size = new System.Drawing.Size(171, 28);
            this.felvitelBtn.TabIndex = 8;
            this.felvitelBtn.Text = "Felvitel";
            this.felvitelBtn.UseVisualStyleBackColor = true;
            this.felvitelBtn.Click += new System.EventHandler(this.felvitelBtn_Click);
            // 
            // vevokListView
            // 
            this.vevokListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.vevokListView.FullRowSelect = true;
            this.vevokListView.HideSelection = false;
            this.vevokListView.Location = new System.Drawing.Point(471, 27);
            this.vevokListView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.vevokListView.Name = "vevokListView";
            this.vevokListView.Size = new System.Drawing.Size(887, 255);
            this.vevokListView.TabIndex = 9;
            this.vevokListView.UseCompatibleStateImageBehavior = false;
            this.vevokListView.View = System.Windows.Forms.View.Details;
            this.vevokListView.SelectedIndexChanged += new System.EventHandler(this.vevokListView_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Vevő  ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Név/Cégnév";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 140;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Vevő típus";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Adószám";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Székhely";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 200;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Aktív vevő";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 100;
            // 
            // passzivBtn
            // 
            this.passzivBtn.Location = new System.Drawing.Point(665, 302);
            this.passzivBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.passzivBtn.Name = "passzivBtn";
            this.passzivBtn.Size = new System.Drawing.Size(163, 28);
            this.passzivBtn.TabIndex = 11;
            this.passzivBtn.Text = "Passzív állományba";
            this.passzivBtn.UseVisualStyleBackColor = true;
            this.passzivBtn.Click += new System.EventHandler(this.passzivBtn_Click);
            // 
            // aktivBtn
            // 
            this.aktivBtn.Location = new System.Drawing.Point(993, 302);
            this.aktivBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.aktivBtn.Name = "aktivBtn";
            this.aktivBtn.Size = new System.Drawing.Size(163, 28);
            this.aktivBtn.TabIndex = 12;
            this.aktivBtn.Text = "Aktív állományba";
            this.aktivBtn.UseVisualStyleBackColor = true;
            this.aktivBtn.Click += new System.EventHandler(this.aktivBtn_Click);
            // 
            // VevokForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1375, 369);
            this.Controls.Add(this.aktivBtn);
            this.Controls.Add(this.passzivBtn);
            this.Controls.Add(this.vevokListView);
            this.Controls.Add(this.felvitelBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.szekhelyTxt);
            this.Controls.Add(this.adoSzamTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.vevoTipusCombo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.vevoNevTxt);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "VevokForm";
            this.Text = "VevokForm";
            this.Load += new System.EventHandler(this.VevokForm_Load);
            this.Click += new System.EventHandler(this.VevokForm_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox vevoNevTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox vevoTipusCombo;
        private System.Windows.Forms.TextBox adoSzamTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox szekhelyTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button felvitelBtn;
        private System.Windows.Forms.ListView vevokListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button passzivBtn;
        private System.Windows.Forms.Button aktivBtn;
    }
}