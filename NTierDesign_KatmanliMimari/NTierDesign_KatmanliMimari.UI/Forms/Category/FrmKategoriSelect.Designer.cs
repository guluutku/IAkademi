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
            this.listView1 = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.clmHCategoryID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmHCategoryName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmHCategoryDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmHCategoryID,
            this.clmHCategoryName,
            this.clmHCategoryDescription});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(148, 116);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(527, 291);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
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
            // FrmKategoriSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Name = "FrmKategoriSelect";
            this.Text = "FrmKategoriSelect";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader clmHCategoryID;
        private System.Windows.Forms.ColumnHeader clmHCategoryName;
        private System.Windows.Forms.ColumnHeader clmHCategoryDescription;
    }
}