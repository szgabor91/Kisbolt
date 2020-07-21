namespace Kisbolt
{
    partial class KorabbiVasarlasok
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
            this.sztornoBtn = new System.Windows.Forms.Button();
            this.vevoListView = new System.Windows.Forms.ListView();
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.vasarlasTetelekListView = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.vasarlasokListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sztornoVisszaBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sztornoBtn
            // 
            this.sztornoBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sztornoBtn.Location = new System.Drawing.Point(259, 342);
            this.sztornoBtn.Name = "sztornoBtn";
            this.sztornoBtn.Size = new System.Drawing.Size(92, 23);
            this.sztornoBtn.TabIndex = 18;
            this.sztornoBtn.Text = "Sztornó";
            this.sztornoBtn.UseVisualStyleBackColor = true;
            this.sztornoBtn.Click += new System.EventHandler(this.sztornoBtn_Click);
            // 
            // vevoListView
            // 
            this.vevoListView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.vevoListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13});
            this.vevoListView.FullRowSelect = true;
            this.vevoListView.HideSelection = false;
            this.vevoListView.Location = new System.Drawing.Point(10, 257);
            this.vevoListView.Name = "vevoListView";
            this.vevoListView.Size = new System.Drawing.Size(836, 72);
            this.vevoListView.TabIndex = 17;
            this.vevoListView.UseCompatibleStateImageBehavior = false;
            this.vevoListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Vevő  ID";
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Név/Cégnév";
            this.columnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader9.Width = 140;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Vevő típus";
            this.columnHeader10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader10.Width = 100;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Adószám";
            this.columnHeader11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader11.Width = 100;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Székhely";
            this.columnHeader12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader12.Width = 200;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Aktív vevő";
            this.columnHeader13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader13.Width = 100;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(383, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Vevő";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(595, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Vásárlás tételei";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // vasarlasTetelekListView
            // 
            this.vasarlasTetelekListView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.vasarlasTetelekListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.vasarlasTetelekListView.FullRowSelect = true;
            this.vasarlasTetelekListView.HideSelection = false;
            this.vasarlasTetelekListView.Location = new System.Drawing.Point(466, 38);
            this.vasarlasTetelekListView.Name = "vasarlasTetelekListView";
            this.vasarlasTetelekListView.Size = new System.Drawing.Size(381, 168);
            this.vasarlasTetelekListView.TabIndex = 14;
            this.vasarlasTetelekListView.UseCompatibleStateImageBehavior = false;
            this.vasarlasTetelekListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Tétel ID";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "TermékID";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Terméknév";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 140;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Mennyiség";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader7.Width = 80;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(189, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Vásárlások";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // vasarlasokListView
            // 
            this.vasarlasokListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader14});
            this.vasarlasokListView.FullRowSelect = true;
            this.vasarlasokListView.HideSelection = false;
            this.vasarlasokListView.Location = new System.Drawing.Point(12, 38);
            this.vasarlasokListView.Name = "vasarlasokListView";
            this.vasarlasokListView.Size = new System.Drawing.Size(448, 168);
            this.vasarlasokListView.TabIndex = 12;
            this.vasarlasokListView.UseCompatibleStateImageBehavior = false;
            this.vasarlasokListView.View = System.Windows.Forms.View.Details;
            this.vasarlasokListView.SelectedIndexChanged += new System.EventHandler(this.vasarlasokListView_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Vásárlás azonosító";
            this.columnHeader1.Width = 110;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Vásárlás időpont";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Vevő azonosító";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 120;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Sztornó";
            this.columnHeader14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // sztornoVisszaBtn
            // 
            this.sztornoVisszaBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sztornoVisszaBtn.Location = new System.Drawing.Point(473, 344);
            this.sztornoVisszaBtn.Name = "sztornoVisszaBtn";
            this.sztornoVisszaBtn.Size = new System.Drawing.Size(121, 23);
            this.sztornoVisszaBtn.TabIndex = 19;
            this.sztornoVisszaBtn.Text = "Sztornó visszavonás";
            this.sztornoVisszaBtn.UseVisualStyleBackColor = true;
            this.sztornoVisszaBtn.Click += new System.EventHandler(this.sztornoVisszaBtn_Click);
            // 
            // KorabbiVasarlasok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 379);
            this.Controls.Add(this.sztornoVisszaBtn);
            this.Controls.Add(this.sztornoBtn);
            this.Controls.Add(this.vevoListView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.vasarlasTetelekListView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.vasarlasokListView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "KorabbiVasarlasok";
            this.Text = "KorabbiVasarlasok";
            this.Load += new System.EventHandler(this.KorabbiVasarlasok_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sztornoBtn;
        private System.Windows.Forms.ListView vevoListView;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView vasarlasTetelekListView;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView vasarlasokListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.Button sztornoVisszaBtn;
    }
}