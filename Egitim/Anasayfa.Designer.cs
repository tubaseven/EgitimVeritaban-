namespace Egitim
{
    partial class Anasayfa
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.öğrenciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öğrenciListeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ögrenciEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dersleriListeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.şubeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.şubeleriListeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.öğrenciToolStripMenuItem,
            this.dersToolStripMenuItem,
            this.şubeToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 24);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // öğrenciToolStripMenuItem
            // 
            this.öğrenciToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.öğrenciListeleToolStripMenuItem,
            this.ögrenciEkleToolStripMenuItem});
            this.öğrenciToolStripMenuItem.Name = "öğrenciToolStripMenuItem";
            this.öğrenciToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.öğrenciToolStripMenuItem.Text = "Öğrenci";
            // 
            // öğrenciListeleToolStripMenuItem
            // 
            this.öğrenciListeleToolStripMenuItem.Name = "öğrenciListeleToolStripMenuItem";
            this.öğrenciListeleToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.öğrenciListeleToolStripMenuItem.Text = "Öğrenci Listele";
            this.öğrenciListeleToolStripMenuItem.Click += new System.EventHandler(this.öğrenciListeleToolStripMenuItem_Click);
            // 
            // ögrenciEkleToolStripMenuItem
            // 
            this.ögrenciEkleToolStripMenuItem.Name = "ögrenciEkleToolStripMenuItem";
            this.ögrenciEkleToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ögrenciEkleToolStripMenuItem.Text = "Ögrenci Ekle";
            this.ögrenciEkleToolStripMenuItem.Click += new System.EventHandler(this.ögrenciEkleToolStripMenuItem_Click);
            // 
            // dersToolStripMenuItem
            // 
            this.dersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dersleriListeleToolStripMenuItem});
            this.dersToolStripMenuItem.Name = "dersToolStripMenuItem";
            this.dersToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.dersToolStripMenuItem.Text = "Ders";
            // 
            // dersleriListeleToolStripMenuItem
            // 
            this.dersleriListeleToolStripMenuItem.Name = "dersleriListeleToolStripMenuItem";
            this.dersleriListeleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dersleriListeleToolStripMenuItem.Text = "Dersleri Listele";
            this.dersleriListeleToolStripMenuItem.Click += new System.EventHandler(this.dersleriListeleToolStripMenuItem_Click);
            // 
            // şubeToolStripMenuItem
            // 
            this.şubeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.şubeleriListeleToolStripMenuItem});
            this.şubeToolStripMenuItem.Name = "şubeToolStripMenuItem";
            this.şubeToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.şubeToolStripMenuItem.Text = "Şube";
            // 
            // şubeleriListeleToolStripMenuItem
            // 
            this.şubeleriListeleToolStripMenuItem.Name = "şubeleriListeleToolStripMenuItem";
            this.şubeleriListeleToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.şubeleriListeleToolStripMenuItem.Text = "Şubeleri Listele";
            this.şubeleriListeleToolStripMenuItem.Click += new System.EventHandler(this.şubeleriListeleToolStripMenuItem_Click);
            // 
            // Anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Anasayfa";
            this.Text = "Anasayfa";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem öğrenciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öğrenciListeleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dersleriListeleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem şubeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem şubeleriListeleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ögrenciEkleToolStripMenuItem;
    }
}