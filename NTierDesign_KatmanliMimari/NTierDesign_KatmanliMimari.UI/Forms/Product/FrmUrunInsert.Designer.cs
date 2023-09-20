namespace NTierDesign_KatmanliMimari.UI.Forms.Product
{
    partial class FrmUrunInsert
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
            this.txt_UnitPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_ProductName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_UnitsInStock = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmb_CategoryID = new System.Windows.Forms.ComboBox();
            this.cmb_SupplierID = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.btnSave.Location = new System.Drawing.Point(300, 481);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(196, 74);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "KAYDET";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // txt_UnitPrice
            // 
            this.txt_UnitPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txt_UnitPrice.Location = new System.Drawing.Point(408, 144);
            this.txt_UnitPrice.MaxLength = 2147483647;
            this.txt_UnitPrice.Name = "txt_UnitPrice";
            this.txt_UnitPrice.Size = new System.Drawing.Size(214, 30);
            this.txt_UnitPrice.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.Location = new System.Drawing.Point(189, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 25);
            this.label3.TabIndex = 15;
            this.label3.Text = "FİYAT";
            // 
            // txt_ProductName
            // 
            this.txt_ProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txt_ProductName.Location = new System.Drawing.Point(408, 89);
            this.txt_ProductName.MaxLength = 50;
            this.txt_ProductName.Name = "txt_ProductName";
            this.txt_ProductName.Size = new System.Drawing.Size(214, 30);
            this.txt_ProductName.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(189, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "ÜRÜN ADI";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(223, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(354, 39);
            this.label1.TabIndex = 12;
            this.label1.Text = "ÜRÜN GİRİŞ FORMU";
            // 
            // txt_UnitsInStock
            // 
            this.txt_UnitsInStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txt_UnitsInStock.Location = new System.Drawing.Point(408, 192);
            this.txt_UnitsInStock.MaxLength = 2147483647;
            this.txt_UnitsInStock.Name = "txt_UnitsInStock";
            this.txt_UnitsInStock.Size = new System.Drawing.Size(214, 30);
            this.txt_UnitsInStock.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label4.Location = new System.Drawing.Point(189, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 25);
            this.label4.TabIndex = 18;
            this.label4.Text = "STOK";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label5.Location = new System.Drawing.Point(189, 305);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 25);
            this.label5.TabIndex = 20;
            this.label5.Text = "MARKA";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label6.Location = new System.Drawing.Point(189, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 25);
            this.label6.TabIndex = 21;
            this.label6.Text = "KATEGORİ";
            // 
            // cmb_CategoryID
            // 
            this.cmb_CategoryID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.cmb_CategoryID.FormattingEnabled = true;
            this.cmb_CategoryID.Location = new System.Drawing.Point(408, 242);
            this.cmb_CategoryID.Name = "cmb_CategoryID";
            this.cmb_CategoryID.Size = new System.Drawing.Size(214, 33);
            this.cmb_CategoryID.TabIndex = 22;
            // 
            // cmb_SupplierID
            // 
            this.cmb_SupplierID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.cmb_SupplierID.FormattingEnabled = true;
            this.cmb_SupplierID.Location = new System.Drawing.Point(408, 297);
            this.cmb_SupplierID.Name = "cmb_SupplierID";
            this.cmb_SupplierID.Size = new System.Drawing.Size(214, 33);
            this.cmb_SupplierID.TabIndex = 23;
            // 
            // FrmUrunInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 590);
            this.Controls.Add(this.cmb_SupplierID);
            this.Controls.Add(this.cmb_CategoryID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_UnitsInStock);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txt_UnitPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_ProductName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmUrunInsert";
            this.Text = "FrmUrunInsert";
            this.Load += new System.EventHandler(this.FrmUrunInsert_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txt_UnitPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_ProductName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_UnitsInStock;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmb_CategoryID;
        private System.Windows.Forms.ComboBox cmb_SupplierID;
    }
}