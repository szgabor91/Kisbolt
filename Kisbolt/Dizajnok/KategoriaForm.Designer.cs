namespace Kisbolt
{
    partial class KategoriaForm
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
            this.kategoriaText = new System.Windows.Forms.TextBox();
            this.felvitelBtn = new System.Windows.Forms.Button();
            this.kategoriaListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.torlesBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(19, 66);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kategória elnevezése";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(425, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kategóriák felvitele";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // kategoriaText
            // 
            this.kategoriaText.Location = new System.Drawing.Point(17, 103);
            this.kategoriaText.Margin = new System.Windows.Forms.Padding(4);
            this.kategoriaText.Name = "kategoriaText";
            this.kategoriaText.Size = new System.Drawing.Size(212, 22);
            this.kategoriaText.TabIndex = 2;
            // 
            // felvitelBtn
            // 
            this.felvitelBtn.Location = new System.Drawing.Point(16, 151);
            this.felvitelBtn.Margin = new System.Windows.Forms.Padding(4);
            this.felvitelBtn.Name = "felvitelBtn";
            this.felvitelBtn.Size = new System.Drawing.Size(215, 28);
            this.felvitelBtn.TabIndex = 3;
            this.felvitelBtn.Text = "Felvitel";
            this.felvitelBtn.UseVisualStyleBackColor = true;
            this.felvitelBtn.Click += new System.EventHandler(this.felvitelBtn_Click);
            // 
            // kategoriaListView
            // 
            this.kategoriaListView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kategoriaListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.kategoriaListView.FullRowSelect = true;
            this.kategoriaListView.HideSelection = false;
            this.kategoriaListView.Location = new System.Drawing.Point(295, 66);
            this.kategoriaListView.Margin = new System.Windows.Forms.Padding(4);
            this.kategoriaListView.Name = "kategoriaListView";
            this.kategoriaListView.Size = new System.Drawing.Size(728, 174);
            this.kategoriaListView.TabIndex = 4;
            this.kategoriaListView.UseCompatibleStateImageBehavior = false;
            this.kategoriaListView.View = System.Windows.Forms.View.Details;
            this.kategoriaListView.SelectedIndexChanged += new System.EventHandler(this.kategoriaListView_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Kategória azonosító";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Kategória elnevezése";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 150;
            // 
            // torlesBtn
            // 
            this.torlesBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.torlesBtn.Location = new System.Drawing.Point(623, 257);
            this.torlesBtn.Margin = new System.Windows.Forms.Padding(4);
            this.torlesBtn.MaximumSize = new System.Drawing.Size(75, 25);
            this.torlesBtn.Name = "torlesBtn";
            this.torlesBtn.Size = new System.Drawing.Size(75, 25);
            this.torlesBtn.TabIndex = 5;
            this.torlesBtn.Text = "Törlés";
            this.torlesBtn.UseVisualStyleBackColor = true;
            this.torlesBtn.Click += new System.EventHandler(this.torlesBtn_Click);
            // 
            // KategoriaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 322);
            this.Controls.Add(this.torlesBtn);
            this.Controls.Add(this.kategoriaListView);
            this.Controls.Add(this.felvitelBtn);
            this.Controls.Add(this.kategoriaText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "KategoriaForm";
            this.Text = "KategoriaForm";
            this.Load += new System.EventHandler(this.KategoriaForm_Load);
            this.Click += new System.EventHandler(this.KategoriaForm_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox kategoriaText;
        private System.Windows.Forms.Button felvitelBtn;
        private System.Windows.Forms.ListView kategoriaListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button torlesBtn;
    }
}