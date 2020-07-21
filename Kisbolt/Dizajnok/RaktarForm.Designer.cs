namespace Kisbolt
{
    partial class RaktarForm
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
            this.termekCombo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mennyisegNum = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.beszerzesiArNum = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.beszerzesDateTime = new System.Windows.Forms.DateTimePicker();
            this.felvitenBtn = new System.Windows.Forms.Button();
            this.raktarListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.torlesBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mennyisegNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beszerzesiArNum)).BeginInit();
            this.SuspendLayout();
            // 
            // termekCombo
            // 
            this.termekCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.termekCombo.FormattingEnabled = true;
            this.termekCombo.Location = new System.Drawing.Point(84, 58);
            this.termekCombo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.termekCombo.Name = "termekCombo";
            this.termekCombo.Size = new System.Drawing.Size(160, 24);
            this.termekCombo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(141, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Termék";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(131, 100);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mennyiség";
            // 
            // mennyisegNum
            // 
            this.mennyisegNum.Location = new System.Drawing.Point(84, 133);
            this.mennyisegNum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mennyisegNum.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.mennyisegNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.mennyisegNum.Name = "mennyisegNum";
            this.mennyisegNum.Size = new System.Drawing.Size(160, 22);
            this.mennyisegNum.TabIndex = 3;
            this.mennyisegNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(116, 176);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Beszerzési ár";
            // 
            // beszerzesiArNum
            // 
            this.beszerzesiArNum.Location = new System.Drawing.Point(83, 207);
            this.beszerzesiArNum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.beszerzesiArNum.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.beszerzesiArNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.beszerzesiArNum.Name = "beszerzesiArNum";
            this.beszerzesiArNum.Size = new System.Drawing.Size(161, 22);
            this.beszerzesiArNum.TabIndex = 5;
            this.beszerzesiArNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(99, 251);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Beszerzési időpont";
            // 
            // beszerzesDateTime
            // 
            this.beszerzesDateTime.Location = new System.Drawing.Point(19, 292);
            this.beszerzesDateTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.beszerzesDateTime.Name = "beszerzesDateTime";
            this.beszerzesDateTime.Size = new System.Drawing.Size(275, 22);
            this.beszerzesDateTime.TabIndex = 7;
            // 
            // felvitenBtn
            // 
            this.felvitenBtn.Location = new System.Drawing.Point(83, 342);
            this.felvitenBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.felvitenBtn.Name = "felvitenBtn";
            this.felvitenBtn.Size = new System.Drawing.Size(161, 28);
            this.felvitenBtn.TabIndex = 8;
            this.felvitenBtn.Text = "Felvitel";
            this.felvitenBtn.UseVisualStyleBackColor = true;
            this.felvitenBtn.Click += new System.EventHandler(this.felvitenBtn_Click);
            // 
            // raktarListView
            // 
            this.raktarListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.raktarListView.FullRowSelect = true;
            this.raktarListView.HideSelection = false;
            this.raktarListView.Location = new System.Drawing.Point(329, 26);
            this.raktarListView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.raktarListView.Name = "raktarListView";
            this.raktarListView.Size = new System.Drawing.Size(705, 290);
            this.raktarListView.TabIndex = 9;
            this.raktarListView.UseCompatibleStateImageBehavior = false;
            this.raktarListView.View = System.Windows.Forms.View.Details;
            this.raktarListView.SelectedIndexChanged += new System.EventHandler(this.raktarListView_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Raktár tétel azonosító";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Termék";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Mennyiség";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Beszerzési ár";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Beszerzési időpont";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 100;
            // 
            // torlesBtn
            // 
            this.torlesBtn.Location = new System.Drawing.Point(329, 340);
            this.torlesBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.torlesBtn.Name = "torlesBtn";
            this.torlesBtn.Size = new System.Drawing.Size(707, 28);
            this.torlesBtn.TabIndex = 10;
            this.torlesBtn.Text = "Törlés";
            this.torlesBtn.UseVisualStyleBackColor = true;
            this.torlesBtn.Click += new System.EventHandler(this.torlesBtn_Click);
            // 
            // RaktarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 395);
            this.Controls.Add(this.torlesBtn);
            this.Controls.Add(this.raktarListView);
            this.Controls.Add(this.felvitenBtn);
            this.Controls.Add(this.beszerzesDateTime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.beszerzesiArNum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mennyisegNum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.termekCombo);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "RaktarForm";
            this.Text = "RaktarForm";
            this.Load += new System.EventHandler(this.RaktarForm_Load);
            this.Click += new System.EventHandler(this.RaktarForm_Click);
            ((System.ComponentModel.ISupportInitialize)(this.mennyisegNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beszerzesiArNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox termekCombo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown mennyisegNum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown beszerzesiArNum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker beszerzesDateTime;
        private System.Windows.Forms.Button felvitenBtn;
        private System.Windows.Forms.ListView raktarListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button torlesBtn;
    }
}