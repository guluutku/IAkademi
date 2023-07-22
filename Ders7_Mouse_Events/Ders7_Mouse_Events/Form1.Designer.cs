namespace Ders7_Mouse_Events
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.aaaaaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bbbbbToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aaaaaToolStripMenuItem,
            this.bbbbbToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(110, 48);
            // 
            // aaaaaToolStripMenuItem
            // 
            this.aaaaaToolStripMenuItem.Name = "aaaaaToolStripMenuItem";
            this.aaaaaToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.aaaaaToolStripMenuItem.Text = "aaaaa";
            // 
            // bbbbbToolStripMenuItem
            // 
            this.bbbbbToolStripMenuItem.Name = "bbbbbToolStripMenuItem";
            this.bbbbbToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.bbbbbToolStripMenuItem.Text = "bbbbb";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(241, 308);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(347, 115);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aaaaaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bbbbbToolStripMenuItem;
        private System.Windows.Forms.Button button1;
    }
}

