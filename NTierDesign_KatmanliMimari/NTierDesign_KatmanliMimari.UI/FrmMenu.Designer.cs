﻿namespace NTierDesign_KatmanliMimari.UI
{
    partial class FrmMenu
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
            this.kATEGORİToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kATEGORİGİRİŞToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mARKAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mARKAGİRİŞToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.üRÜNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.üRÜNGİRİŞToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kATEGORİToolStripMenuItem,
            this.mARKAToolStripMenuItem,
            this.üRÜNToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 45);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // kATEGORİToolStripMenuItem
            // 
            this.kATEGORİToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kATEGORİGİRİŞToolStripMenuItem});
            this.kATEGORİToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.kATEGORİToolStripMenuItem.Name = "kATEGORİToolStripMenuItem";
            this.kATEGORİToolStripMenuItem.Size = new System.Drawing.Size(150, 41);
            this.kATEGORİToolStripMenuItem.Text = "KATEGORİ";
            // 
            // kATEGORİGİRİŞToolStripMenuItem
            // 
            this.kATEGORİGİRİŞToolStripMenuItem.Name = "kATEGORİGİRİŞToolStripMenuItem";
            this.kATEGORİGİRİŞToolStripMenuItem.Size = new System.Drawing.Size(285, 42);
            this.kATEGORİGİRİŞToolStripMenuItem.Text = "KATEGORİ GİRİŞ";
            this.kATEGORİGİRİŞToolStripMenuItem.Click += new System.EventHandler(this.kATEGORİGİRİŞToolStripMenuItem_Click);
            // 
            // mARKAToolStripMenuItem
            // 
            this.mARKAToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mARKAGİRİŞToolStripMenuItem});
            this.mARKAToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.mARKAToolStripMenuItem.Name = "mARKAToolStripMenuItem";
            this.mARKAToolStripMenuItem.Size = new System.Drawing.Size(119, 41);
            this.mARKAToolStripMenuItem.Text = "MARKA";
            // 
            // mARKAGİRİŞToolStripMenuItem
            // 
            this.mARKAGİRİŞToolStripMenuItem.Name = "mARKAGİRİŞToolStripMenuItem";
            this.mARKAGİRİŞToolStripMenuItem.Size = new System.Drawing.Size(254, 42);
            this.mARKAGİRİŞToolStripMenuItem.Text = "MARKA GİRİŞ";
            this.mARKAGİRİŞToolStripMenuItem.Click += new System.EventHandler(this.mARKAGİRİŞToolStripMenuItem_Click);
            // 
            // üRÜNToolStripMenuItem
            // 
            this.üRÜNToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.üRÜNGİRİŞToolStripMenuItem});
            this.üRÜNToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.üRÜNToolStripMenuItem.Name = "üRÜNToolStripMenuItem";
            this.üRÜNToolStripMenuItem.Size = new System.Drawing.Size(103, 41);
            this.üRÜNToolStripMenuItem.Text = "ÜRÜN";
            // 
            // üRÜNGİRİŞToolStripMenuItem
            // 
            this.üRÜNGİRİŞToolStripMenuItem.Name = "üRÜNGİRİŞToolStripMenuItem";
            this.üRÜNGİRİŞToolStripMenuItem.Size = new System.Drawing.Size(238, 42);
            this.üRÜNGİRİŞToolStripMenuItem.Text = "ÜRÜN GİRİŞ";
            this.üRÜNGİRİŞToolStripMenuItem.Click += new System.EventHandler(this.üRÜNGİRİŞToolStripMenuItem_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMenu";
            this.Text = "FrmMenu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kATEGORİToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kATEGORİGİRİŞToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mARKAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mARKAGİRİŞToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem üRÜNToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem üRÜNGİRİŞToolStripMenuItem;
    }
}