namespace Kisbolt
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.beállításokToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.termékkategóriaFelviteleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.termékFelviteleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raktárKezeléseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vásárlásFelviteleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vevőkFelviteleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.korábbiVásárlásokToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.belepesGroup = new System.Windows.Forms.GroupBox();
            this.belepesBtn = new System.Windows.Forms.Button();
            this.jelszoTxt = new System.Windows.Forms.TextBox();
            this.jelszoLabel = new System.Windows.Forms.Label();
            this.felhNevTxt = new System.Windows.Forms.TextBox();
            this.felhLabel = new System.Windows.Forms.Label();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.menuStrip1.SuspendLayout();
            this.belepesGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.beállításokToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(889, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // beállításokToolStripMenuItem
            // 
            this.beállításokToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.termékkategóriaFelviteleToolStripMenuItem,
            this.termékFelviteleToolStripMenuItem,
            this.raktárKezeléseToolStripMenuItem,
            this.vásárlásFelviteleToolStripMenuItem,
            this.vevőkFelviteleToolStripMenuItem,
            this.korábbiVásárlásokToolStripMenuItem});
            this.beállításokToolStripMenuItem.Name = "beállításokToolStripMenuItem";
            this.beállításokToolStripMenuItem.Size = new System.Drawing.Size(95, 24);
            this.beállításokToolStripMenuItem.Text = "Beállítások";
            // 
            // termékkategóriaFelviteleToolStripMenuItem
            // 
            this.termékkategóriaFelviteleToolStripMenuItem.Name = "termékkategóriaFelviteleToolStripMenuItem";
            this.termékkategóriaFelviteleToolStripMenuItem.Size = new System.Drawing.Size(260, 26);
            this.termékkategóriaFelviteleToolStripMenuItem.Text = "Termékkategória felvitele";
            this.termékkategóriaFelviteleToolStripMenuItem.Click += new System.EventHandler(this.termékkategóriaFelviteleToolStripMenuItem_Click);
            // 
            // termékFelviteleToolStripMenuItem
            // 
            this.termékFelviteleToolStripMenuItem.Name = "termékFelviteleToolStripMenuItem";
            this.termékFelviteleToolStripMenuItem.Size = new System.Drawing.Size(260, 26);
            this.termékFelviteleToolStripMenuItem.Text = "Termék felvitele";
            this.termékFelviteleToolStripMenuItem.Click += new System.EventHandler(this.termékFelviteleToolStripMenuItem_Click);
            // 
            // raktárKezeléseToolStripMenuItem
            // 
            this.raktárKezeléseToolStripMenuItem.Name = "raktárKezeléseToolStripMenuItem";
            this.raktárKezeléseToolStripMenuItem.Size = new System.Drawing.Size(260, 26);
            this.raktárKezeléseToolStripMenuItem.Text = "Raktár kezelése";
            this.raktárKezeléseToolStripMenuItem.Click += new System.EventHandler(this.raktárKezeléseToolStripMenuItem_Click);
            // 
            // vásárlásFelviteleToolStripMenuItem
            // 
            this.vásárlásFelviteleToolStripMenuItem.Name = "vásárlásFelviteleToolStripMenuItem";
            this.vásárlásFelviteleToolStripMenuItem.Size = new System.Drawing.Size(260, 26);
            this.vásárlásFelviteleToolStripMenuItem.Text = "Vásárlás felvitele";
            this.vásárlásFelviteleToolStripMenuItem.Click += new System.EventHandler(this.vásárlásFelviteleToolStripMenuItem_Click);
            // 
            // vevőkFelviteleToolStripMenuItem
            // 
            this.vevőkFelviteleToolStripMenuItem.Name = "vevőkFelviteleToolStripMenuItem";
            this.vevőkFelviteleToolStripMenuItem.Size = new System.Drawing.Size(260, 26);
            this.vevőkFelviteleToolStripMenuItem.Text = "Vevők felvitele";
            this.vevőkFelviteleToolStripMenuItem.Click += new System.EventHandler(this.vevőkFelviteleToolStripMenuItem_Click);
            // 
            // korábbiVásárlásokToolStripMenuItem
            // 
            this.korábbiVásárlásokToolStripMenuItem.Name = "korábbiVásárlásokToolStripMenuItem";
            this.korábbiVásárlásokToolStripMenuItem.Size = new System.Drawing.Size(260, 26);
            this.korábbiVásárlásokToolStripMenuItem.Text = "Korábbi vásárlások";
            this.korábbiVásárlásokToolStripMenuItem.Click += new System.EventHandler(this.korábbiVásárlásokToolStripMenuItem_Click);
            // 
            // belepesGroup
            // 
            this.belepesGroup.Controls.Add(this.belepesBtn);
            this.belepesGroup.Controls.Add(this.jelszoTxt);
            this.belepesGroup.Controls.Add(this.jelszoLabel);
            this.belepesGroup.Controls.Add(this.felhNevTxt);
            this.belepesGroup.Controls.Add(this.felhLabel);
            this.belepesGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.belepesGroup.Location = new System.Drawing.Point(127, 76);
            this.belepesGroup.Name = "belepesGroup";
            this.belepesGroup.Size = new System.Drawing.Size(639, 267);
            this.belepesGroup.TabIndex = 5;
            this.belepesGroup.TabStop = false;
            this.belepesGroup.Text = "Belépés";
            // 
            // belepesBtn
            // 
            this.belepesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.belepesBtn.Location = new System.Drawing.Point(233, 212);
            this.belepesBtn.Name = "belepesBtn";
            this.belepesBtn.Size = new System.Drawing.Size(151, 36);
            this.belepesBtn.TabIndex = 4;
            this.belepesBtn.Text = "Belépés";
            this.belepesBtn.UseVisualStyleBackColor = true;
            this.belepesBtn.Click += new System.EventHandler(this.belepesBtn_Click);
            // 
            // jelszoTxt
            // 
            this.jelszoTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.jelszoTxt.Location = new System.Drawing.Point(158, 160);
            this.jelszoTxt.Name = "jelszoTxt";
            this.jelszoTxt.PasswordChar = '*';
            this.jelszoTxt.Size = new System.Drawing.Size(274, 27);
            this.jelszoTxt.TabIndex = 3;
            // 
            // jelszoLabel
            // 
            this.jelszoLabel.AutoSize = true;
            this.jelszoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.jelszoLabel.Location = new System.Drawing.Point(262, 133);
            this.jelszoLabel.Name = "jelszoLabel";
            this.jelszoLabel.Size = new System.Drawing.Size(63, 24);
            this.jelszoLabel.TabIndex = 2;
            this.jelszoLabel.Text = "Jelszó";
            // 
            // felhNevTxt
            // 
            this.felhNevTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.felhNevTxt.Location = new System.Drawing.Point(158, 83);
            this.felhNevTxt.Name = "felhNevTxt";
            this.felhNevTxt.Size = new System.Drawing.Size(274, 27);
            this.felhNevTxt.TabIndex = 1;
            // 
            // felhLabel
            // 
            this.felhLabel.AutoSize = true;
            this.felhLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.felhLabel.Location = new System.Drawing.Point(229, 56);
            this.felhLabel.Name = "felhLabel";
            this.felhLabel.Size = new System.Drawing.Size(143, 24);
            this.felhLabel.TabIndex = 0;
            this.felhLabel.Text = "Felhasználónév";
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Kisbolt";
            this.notifyIcon.Visible = true;
            this.notifyIcon.DoubleClick += new System.EventHandler(this.notifyIcon_DoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 475);
            this.Controls.Add(this.belepesGroup);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.belepesGroup.ResumeLayout(false);
            this.belepesGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem beállításokToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem termékkategóriaFelviteleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem termékFelviteleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem raktárKezeléseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vásárlásFelviteleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vevőkFelviteleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem korábbiVásárlásokToolStripMenuItem;
        private System.Windows.Forms.GroupBox belepesGroup;
        private System.Windows.Forms.Button belepesBtn;
        private System.Windows.Forms.TextBox jelszoTxt;
        private System.Windows.Forms.Label jelszoLabel;
        private System.Windows.Forms.TextBox felhNevTxt;
        private System.Windows.Forms.Label felhLabel;
        private System.Windows.Forms.NotifyIcon notifyIcon;
    }
}

