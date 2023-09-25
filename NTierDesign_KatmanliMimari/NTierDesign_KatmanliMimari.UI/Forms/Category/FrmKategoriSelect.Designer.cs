namespace NTierDesign_KatmanliMimari.UI.Forms.Category
{
    partial class FrmKategoriSelect
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
            this.lst_categoryList = new System.Windows.Forms.ListView();
            this.clmHCategoryID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmHCategoryName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmHCategoryDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_description = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lst_categoryList
            // 
            this.lst_categoryList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmHCategoryID,
            this.clmHCategoryName,
            this.clmHCategoryDescription});
            this.lst_categoryList.FullRowSelect = true;
            this.lst_categoryList.HideSelection = false;
            this.lst_categoryList.Location = new System.Drawing.Point(151, 188);
            this.lst_categoryList.Name = "lst_categoryList";
            this.lst_categoryList.Size = new System.Drawing.Size(527, 291);
            this.lst_categoryList.TabIndex = 0;
            this.lst_categoryList.UseCompatibleStateImageBehavior = false;
            this.lst_categoryList.View = System.Windows.Forms.View.Details;
            this.lst_categoryList.Click += new System.EventHandler(this.lst_categoryList_Click);
            // 
            // clmHCategoryID
            // 
            this.clmHCategoryID.Text = "ID";
            this.clmHCategoryID.Width = 94;
            // 
            // clmHCategoryName
            // 
            this.clmHCategoryName.Text = "KATEGORİ ADI";
            this.clmHCategoryName.Width = 228;
            // 
            // clmHCategoryDescription
            // 
            this.clmHCategoryDescription.Text = "AÇIKLAMA";
            this.clmHCategoryDescription.Width = 200;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label1.Location = new System.Drawing.Point(225, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "KATEGORİ LİSTESİ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(148, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "KATEGORİ ARA";
            // 
            // txt_search
            // 
            this.txt_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txt_search.Location = new System.Drawing.Point(394, 120);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(196, 23);
            this.txt_search.TabIndex = 3;
            this.txt_search.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_search_KeyUp);
            // 
            // btn_update
            // 
            this.btn_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btn_update.Location = new System.Drawing.Point(166, 555);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(189, 82);
            this.btn_update.TabIndex = 4;
            this.btn_update.Text = "GÜNCELLE";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btn_delete.Location = new System.Drawing.Point(495, 555);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(121, 82);
            this.btn_delete.TabIndex = 5;
            this.btn_delete.Text = "SİL";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(151, 508);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(227, 20);
            this.txt_name.TabIndex = 6;
            // 
            // txt_description
            // 
            this.txt_description.Location = new System.Drawing.Point(470, 508);
            this.txt_description.Name = "txt_description";
            this.txt_description.Size = new System.Drawing.Size(199, 20);
            this.txt_description.TabIndex = 7;
            // 
            // FrmKategoriSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 667);
            this.Controls.Add(this.txt_description);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lst_categoryList);
            this.Name = "FrmKategoriSelect";
            this.Text = "FrmKategoriSelect";
            this.Load += new System.EventHandler(this.FrmKategoriSelect_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lst_categoryList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader clmHCategoryID;
        private System.Windows.Forms.ColumnHeader clmHCategoryName;
        private System.Windows.Forms.ColumnHeader clmHCategoryDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_description;
    }
}