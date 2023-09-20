namespace NTierDesign_KatmanliMimari.UI.Forms.Supplier
{
    partial class FrmSupplierInsert
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
            this.btnSave = new System.Windows.Forms.Button();
            this.txt_ContactName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_CompanyName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.btnSave.Location = new System.Drawing.Point(245, 293);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(294, 113);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "KAYDET";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txt_ContactName
            // 
            this.txt_ContactName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txt_ContactName.Location = new System.Drawing.Point(407, 198);
            this.txt_ContactName.MaxLength = 2147483647;
            this.txt_ContactName.Name = "txt_ContactName";
            this.txt_ContactName.Size = new System.Drawing.Size(214, 30);
            this.txt_ContactName.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.Location = new System.Drawing.Point(177, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "İLETİŞİM BİLGİLERİ";
            // 
            // txt_CompanyName
            // 
            this.txt_CompanyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txt_CompanyName.Location = new System.Drawing.Point(407, 131);
            this.txt_CompanyName.MaxLength = 50;
            this.txt_CompanyName.Name = "txt_CompanyName";
            this.txt_CompanyName.Size = new System.Drawing.Size(214, 30);
            this.txt_CompanyName.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(188, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "ŞİRKET ADI";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(238, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(376, 39);
            this.label1.TabIndex = 6;
            this.label1.Text = "MARKA GİRİŞ FORMU";
            // 
            // FrmSupplierInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txt_ContactName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_CompanyName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmSupplierInsert";
            this.Text = "FrmSupplierInsert";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txt_ContactName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_CompanyName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}