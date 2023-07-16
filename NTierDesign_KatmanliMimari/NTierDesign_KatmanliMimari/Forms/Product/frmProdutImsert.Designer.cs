namespace NTierDesign_KatmanliMimari.Forms.Product
{
    partial class frmProdutImsert
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_product_adi = new System.Windows.Forms.TextBox();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label2.Location = new System.Drawing.Point(209, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(256, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "ÜRÜN GİRİŞ FORMU";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label1.Location = new System.Drawing.Point(134, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "ÜRÜN ADI";
            // 
            // txt_product_adi
            // 
            this.txt_product_adi.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.txt_product_adi.Location = new System.Drawing.Point(389, 115);
            this.txt_product_adi.Name = "txt_product_adi";
            this.txt_product_adi.Size = new System.Drawing.Size(220, 35);
            this.txt_product_adi.TabIndex = 5;
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_kaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
            this.btn_kaydet.Location = new System.Drawing.Point(283, 312);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(177, 71);
            this.btn_kaydet.TabIndex = 4;
            this.btn_kaydet.Text = "KAYDET";
            this.btn_kaydet.UseVisualStyleBackColor = false;
            // 
            // frmProdutImsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_product_adi);
            this.Controls.Add(this.btn_kaydet);
            this.Name = "frmProdutImsert";
            this.Text = "frmProdutImsert";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_product_adi;
        private System.Windows.Forms.Button btn_kaydet;
    }
}