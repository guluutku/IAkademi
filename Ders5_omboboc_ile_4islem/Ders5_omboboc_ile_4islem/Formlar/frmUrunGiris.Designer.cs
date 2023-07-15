namespace Ders5_omboboc_ile_4islem
{
    partial class frmUrunGiris
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
            this.lbl_telefonNo = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_telefonNo
            // 
            this.lbl_telefonNo.AutoSize = true;
            this.lbl_telefonNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.lbl_telefonNo.Location = new System.Drawing.Point(322, 182);
            this.lbl_telefonNo.Name = "lbl_telefonNo";
            this.lbl_telefonNo.Size = new System.Drawing.Size(193, 31);
            this.lbl_telefonNo.TabIndex = 12;
            this.lbl_telefonNo.Text = "0506 502 5467";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label5.Location = new System.Drawing.Point(176, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 31);
            this.label5.TabIndex = 11;
            this.label5.Text = "TELEFON";
            // 
            // frmUrunGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_telefonNo);
            this.Controls.Add(this.label5);
            this.Name = "frmUrunGiris";
            this.Text = "frmUrunGiris";
            this.Load += new System.EventHandler(this.frmUrunGiris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_telefonNo;
        private System.Windows.Forms.Label label5;
    }
}