﻿namespace Egitim
{
    partial class OgrenciListele
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
            this.grd_Ogrenci = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.düzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.grd_Ogrenci)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grd_Ogrenci
            // 
            this.grd_Ogrenci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_Ogrenci.ContextMenuStrip = this.contextMenuStrip1;
            this.grd_Ogrenci.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_Ogrenci.Location = new System.Drawing.Point(0, 0);
            this.grd_Ogrenci.Name = "grd_Ogrenci";
            this.grd_Ogrenci.Size = new System.Drawing.Size(800, 450);
            this.grd_Ogrenci.TabIndex = 0;
            this.grd_Ogrenci.ContextMenuStripChanged += new System.EventHandler(this.OgrenciListele_Load);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.düzenleToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(117, 26);
            this.contextMenuStrip1.Click += new System.EventHandler(this.düzenleToolStripMenuItem_Click);
            // 
            // düzenleToolStripMenuItem
            // 
            this.düzenleToolStripMenuItem.Name = "düzenleToolStripMenuItem";
            this.düzenleToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.düzenleToolStripMenuItem.Text = "Düzenle";
            this.düzenleToolStripMenuItem.Click += new System.EventHandler(this.düzenleToolStripMenuItem_Click);
            // 
            // OgrenciListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grd_Ogrenci);
            this.Name = "OgrenciListele";
            this.Text = "OgrenciListele";
            this.Load += new System.EventHandler(this.OgrenciListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grd_Ogrenci)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grd_Ogrenci;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem düzenleToolStripMenuItem;
    }
}