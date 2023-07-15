namespace Ders5_omboboc_ile_4islem.Formlar
{
    partial class frm_SabitBigiler
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
            this.txt_telefonNo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.25F);
            this.label1.Location = new System.Drawing.Point(121, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "TELEFON NO";
            // 
            // txt_telefonNo
            // 
            this.txt_telefonNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.25F);
            this.txt_telefonNo.Location = new System.Drawing.Point(477, 200);
            this.txt_telefonNo.Name = "txt_telefonNo";
            this.txt_telefonNo.Size = new System.Drawing.Size(345, 50);
            this.txt_telefonNo.TabIndex = 1;
            // 
            // frm_SabitBigiler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 611);
            this.Controls.Add(this.txt_telefonNo);
            this.Controls.Add(this.label1);
            this.Name = "frm_SabitBigiler";
            this.Text = "frm_SabitBigiler";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_telefonNo;
    }
}