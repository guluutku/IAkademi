namespace NTierDesign_KatmanliMimari.UI.Forms.Supplier
{
    partial class FrmSupplierSelect
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
            this.txt_contactName = new System.Windows.Forms.TextBox();
            this.txt_companyName = new System.Windows.Forms.TextBox();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lst_supplierList = new System.Windows.Forms.ListView();
            this.clmHSupplierID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmHCompanyName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmHSupplierContactName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_contactName
            // 
            this.txt_contactName.Location = new System.Drawing.Point(458, 539);
            this.txt_contactName.Name = "txt_contactName";
            this.txt_contactName.Size = new System.Drawing.Size(199, 20);
            this.txt_contactName.TabIndex = 15;
            // 
            // txt_companyName
            // 
            this.txt_companyName.Location = new System.Drawing.Point(139, 539);
            this.txt_companyName.Name = "txt_companyName";
            this.txt_companyName.Size = new System.Drawing.Size(227, 20);
            this.txt_companyName.TabIndex = 14;
            // 
            // btn_delete
            // 
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btn_delete.Location = new System.Drawing.Point(483, 586);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(121, 82);
            this.btn_delete.TabIndex = 13;
            this.btn_delete.Text = "SİL";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_update
            // 
            this.btn_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btn_update.Location = new System.Drawing.Point(154, 586);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(189, 82);
            this.btn_update.TabIndex = 12;
            this.btn_update.Text = "GÜNCELLE";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // txt_search
            // 
            this.txt_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txt_search.Location = new System.Drawing.Point(382, 151);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(196, 23);
            this.txt_search.TabIndex = 11;
            this.txt_search.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_search_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(136, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "MARKA ARA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label1.Location = new System.Drawing.Point(212, -78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 39);
            this.label1.TabIndex = 9;
            this.label1.Text = "KATEGORİ LİSTESİ";
            // 
            // lst_supplierList
            // 
            this.lst_supplierList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmHSupplierID,
            this.clmHCompanyName,
            this.clmHSupplierContactName});
            this.lst_supplierList.FullRowSelect = true;
            this.lst_supplierList.HideSelection = false;
            this.lst_supplierList.Location = new System.Drawing.Point(139, 219);
            this.lst_supplierList.Name = "lst_supplierList";
            this.lst_supplierList.Size = new System.Drawing.Size(527, 291);
            this.lst_supplierList.TabIndex = 8;
            this.lst_supplierList.UseCompatibleStateImageBehavior = false;
            this.lst_supplierList.View = System.Windows.Forms.View.Details;
            this.lst_supplierList.Click += new System.EventHandler(this.lst_supplierList_Click);
            // 
            // clmHSupplierID
            // 
            this.clmHSupplierID.Text = "ID";
            this.clmHSupplierID.Width = 94;
            // 
            // clmHCompanyName
            // 
            this.clmHCompanyName.Text = "MARKA ADI";
            this.clmHCompanyName.Width = 228;
            // 
            // clmHSupplierContactName
            // 
            this.clmHSupplierContactName.Text = "BAĞLANTI ADI";
            this.clmHSupplierContactName.Width = 200;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label3.Location = new System.Drawing.Point(303, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(277, 39);
            this.label3.TabIndex = 16;
            this.label3.Text = "MARKA LİSTESİ";
            // 
            // FrmSupplierSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 713);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_contactName);
            this.Controls.Add(this.txt_companyName);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lst_supplierList);
            this.Name = "FrmSupplierSelect";
            this.Text = "FrmSupplierSelect";
            this.Load += new System.EventHandler(this.FrmSupplierSelect_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_contactName;
        private System.Windows.Forms.TextBox txt_companyName;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lst_supplierList;
        private System.Windows.Forms.ColumnHeader clmHSupplierID;
        private System.Windows.Forms.ColumnHeader clmHCompanyName;
        private System.Windows.Forms.ColumnHeader clmHSupplierContactName;
        private System.Windows.Forms.Label label3;
    }
}