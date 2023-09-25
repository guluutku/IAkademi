namespace NTierDesign_KatmanliMimari.UI.Forms.Product
{
    partial class FrmUrunListele
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
            this.txt_search = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lst_productList = new System.Windows.Forms.ListView();
            this.clmHProductID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmHProductName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmHProductPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmHStock = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmHCategoryName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columclmHSuppliername = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txt_urunAdi = new System.Windows.Forms.TextBox();
            this.txt_fiyat = new System.Windows.Forms.TextBox();
            this.txt_stok = new System.Windows.Forms.TextBox();
            this.cmb_kategoriAdi = new System.Windows.Forms.ComboBox();
            this.cmb_markaAdi = new System.Windows.Forms.ComboBox();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_search
            // 
            this.txt_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txt_search.Location = new System.Drawing.Point(292, 94);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(196, 23);
            this.txt_search.TabIndex = 7;
            this.txt_search.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_search_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(135, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "ÜRÜN ARA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label1.Location = new System.Drawing.Point(440, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 39);
            this.label1.TabIndex = 5;
            this.label1.Text = "ÜRÜN LİSTESİ";
            // 
            // lst_productList
            // 
            this.lst_productList.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lst_productList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmHProductID,
            this.clmHProductName,
            this.clmHProductPrice,
            this.clmHStock,
            this.clmHCategoryName,
            this.columclmHSuppliername});
            this.lst_productList.FullRowSelect = true;
            this.lst_productList.GridLines = true;
            this.lst_productList.HideSelection = false;
            this.lst_productList.Location = new System.Drawing.Point(94, 157);
            this.lst_productList.Name = "lst_productList";
            this.lst_productList.Size = new System.Drawing.Size(867, 262);
            this.lst_productList.TabIndex = 4;
            this.lst_productList.UseCompatibleStateImageBehavior = false;
            this.lst_productList.View = System.Windows.Forms.View.Details;
            this.lst_productList.Click += new System.EventHandler(this.lst_productList_Click);
            // 
            // clmHProductID
            // 
            this.clmHProductID.Text = "ID";
            this.clmHProductID.Width = 94;
            // 
            // clmHProductName
            // 
            this.clmHProductName.Text = "ÜRÜN ADI";
            this.clmHProductName.Width = 228;
            // 
            // clmHProductPrice
            // 
            this.clmHProductPrice.Text = "FİYAT";
            this.clmHProductPrice.Width = 171;
            // 
            // clmHStock
            // 
            this.clmHStock.Text = "STOK";
            // 
            // clmHCategoryName
            // 
            this.clmHCategoryName.Text = "KATAGORİ ADI";
            this.clmHCategoryName.Width = 146;
            // 
            // columclmHSuppliername
            // 
            this.columclmHSuppliername.Text = "MARKA ADI";
            this.columclmHSuppliername.Width = 163;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.Location = new System.Drawing.Point(610, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "SIRALAMA";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(765, 100);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(196, 21);
            this.comboBox1.TabIndex = 9;
            // 
            // txt_urunAdi
            // 
            this.txt_urunAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txt_urunAdi.Location = new System.Drawing.Point(52, 449);
            this.txt_urunAdi.Name = "txt_urunAdi";
            this.txt_urunAdi.Size = new System.Drawing.Size(196, 23);
            this.txt_urunAdi.TabIndex = 10;
            // 
            // txt_fiyat
            // 
            this.txt_fiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txt_fiyat.Location = new System.Drawing.Point(274, 449);
            this.txt_fiyat.Name = "txt_fiyat";
            this.txt_fiyat.Size = new System.Drawing.Size(138, 23);
            this.txt_fiyat.TabIndex = 11;
            // 
            // txt_stok
            // 
            this.txt_stok.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txt_stok.Location = new System.Drawing.Point(457, 449);
            this.txt_stok.Name = "txt_stok";
            this.txt_stok.Size = new System.Drawing.Size(139, 23);
            this.txt_stok.TabIndex = 12;
            // 
            // cmb_kategoriAdi
            // 
            this.cmb_kategoriAdi.FormattingEnabled = true;
            this.cmb_kategoriAdi.Location = new System.Drawing.Point(635, 451);
            this.cmb_kategoriAdi.Name = "cmb_kategoriAdi";
            this.cmb_kategoriAdi.Size = new System.Drawing.Size(196, 21);
            this.cmb_kategoriAdi.TabIndex = 13;
            // 
            // cmb_markaAdi
            // 
            this.cmb_markaAdi.FormattingEnabled = true;
            this.cmb_markaAdi.Location = new System.Drawing.Point(871, 451);
            this.cmb_markaAdi.Name = "cmb_markaAdi";
            this.cmb_markaAdi.Size = new System.Drawing.Size(196, 21);
            this.cmb_markaAdi.TabIndex = 14;
            // 
            // btn_delete
            // 
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btn_delete.Location = new System.Drawing.Point(787, 543);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(121, 82);
            this.btn_delete.TabIndex = 16;
            this.btn_delete.Text = "SİL";
            this.btn_delete.UseVisualStyleBackColor = true;
            // 
            // btn_update
            // 
            this.btn_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btn_update.Location = new System.Drawing.Point(155, 543);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(189, 82);
            this.btn_update.TabIndex = 15;
            this.btn_update.Text = "GÜNCELLE";
            this.btn_update.UseVisualStyleBackColor = true;
            // 
            // FrmUrunListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1128, 738);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.cmb_markaAdi);
            this.Controls.Add(this.cmb_kategoriAdi);
            this.Controls.Add(this.txt_stok);
            this.Controls.Add(this.txt_fiyat);
            this.Controls.Add(this.txt_urunAdi);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lst_productList);
            this.Name = "FrmUrunListele";
            this.Text = "FrmUrunListele";
            this.Load += new System.EventHandler(this.FrmUrunListele_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lst_productList;
        private System.Windows.Forms.ColumnHeader clmHProductID;
        private System.Windows.Forms.ColumnHeader clmHProductName;
        private System.Windows.Forms.ColumnHeader clmHProductPrice;
        private System.Windows.Forms.ColumnHeader clmHStock;
        private System.Windows.Forms.ColumnHeader clmHCategoryName;
        private System.Windows.Forms.ColumnHeader columclmHSuppliername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txt_urunAdi;
        private System.Windows.Forms.TextBox txt_fiyat;
        private System.Windows.Forms.TextBox txt_stok;
        private System.Windows.Forms.ComboBox cmb_kategoriAdi;
        private System.Windows.Forms.ComboBox cmb_markaAdi;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
    }
}