namespace Ders35_Okul38Proje
{
    partial class frmMenu
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
            this.öĞRENCİToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dERSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öĞRENCİGİRİŞFORMUToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.öĞRENCİToolStripMenuItem,
            this.dERSToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 45);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // öĞRENCİToolStripMenuItem
            // 
            this.öĞRENCİToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.öĞRENCİGİRİŞFORMUToolStripMenuItem});
            this.öĞRENCİToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.öĞRENCİToolStripMenuItem.Name = "öĞRENCİToolStripMenuItem";
            this.öĞRENCİToolStripMenuItem.Size = new System.Drawing.Size(142, 41);
            this.öĞRENCİToolStripMenuItem.Text = "ÖĞRENCİ";
            // 
            // dERSToolStripMenuItem
            // 
            this.dERSToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.dERSToolStripMenuItem.Name = "dERSToolStripMenuItem";
            this.dERSToolStripMenuItem.Size = new System.Drawing.Size(92, 41);
            this.dERSToolStripMenuItem.Text = "DERS";
            // 
            // öĞRENCİGİRİŞFORMUToolStripMenuItem
            // 
            this.öĞRENCİGİRİŞFORMUToolStripMenuItem.Name = "öĞRENCİGİRİŞFORMUToolStripMenuItem";
            this.öĞRENCİGİRİŞFORMUToolStripMenuItem.Size = new System.Drawing.Size(376, 42);
            this.öĞRENCİGİRİŞFORMUToolStripMenuItem.Text = "ÖĞRENCİ GİRİŞ FORMU";
            this.öĞRENCİGİRİŞFORMUToolStripMenuItem.Click += new System.EventHandler(this.öĞRENCİGİRİŞFORMUToolStripMenuItem_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMenu";
            this.Text = "frmMenu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem öĞRENCİToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dERSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öĞRENCİGİRİŞFORMUToolStripMenuItem;
    }
}