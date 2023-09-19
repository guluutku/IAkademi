namespace NTierDesign_KatmanliMimari.Forms.Category
{
    partial class frmCategoryInsert
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
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.txt_category_adi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_kaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
            this.btn_kaydet.Location = new System.Drawing.Point(231, 291);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(177, 71);
            this.btn_kaydet.TabIndex = 0;
            this.btn_kaydet.Text = "KAYDET";
            this.btn_kaydet.UseVisualStyleBackColor = false;
            // 
            // txt_category_adi
            // 
            this.txt_category_adi.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.txt_category_adi.Location = new System.Drawing.Point(421, 91);
            this.txt_category_adi.Name = "txt_category_adi";
            this.txt_category_adi.Size = new System.Drawing.Size(220, 35);
            this.txt_category_adi.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label1.Location = new System.Drawing.Point(166, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "KATEGORİ ADI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label2.Location = new System.Drawing.Point(241, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(312, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "KATEGORİ GİRİŞ FORMU";
            // 
            // frmCategoryInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_category_adi);
            this.Controls.Add(this.btn_kaydet);
            this.Name = "frmCategoryInsert";
            this.Text = "frmCategoryInsert";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_kaydet;
        private System.Windows.Forms.TextBox txt_category_adi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}