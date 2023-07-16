namespace Ders6_ListView_Encapsulation
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_isim = new System.Windows.Forms.TextBox();
            this.txt_bolum = new System.Windows.Forms.TextBox();
            this.txt_ogretmen_ismi = new System.Windows.Forms.TextBox();
            this.txt_tc_kimlik = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label1.Location = new System.Drawing.Point(34, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "İSİM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label2.Location = new System.Drawing.Point(34, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "ÖĞRETMEN İSMİ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label3.Location = new System.Drawing.Point(34, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "BÖLÜM";
            // 
            // txt_isim
            // 
            this.txt_isim.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.txt_isim.Location = new System.Drawing.Point(314, 63);
            this.txt_isim.Name = "txt_isim";
            this.txt_isim.Size = new System.Drawing.Size(220, 31);
            this.txt_isim.TabIndex = 3;
            // 
            // txt_bolum
            // 
            this.txt_bolum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.txt_bolum.Location = new System.Drawing.Point(314, 188);
            this.txt_bolum.Name = "txt_bolum";
            this.txt_bolum.Size = new System.Drawing.Size(220, 31);
            this.txt_bolum.TabIndex = 4;
            // 
            // txt_ogretmen_ismi
            // 
            this.txt_ogretmen_ismi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.txt_ogretmen_ismi.Location = new System.Drawing.Point(314, 128);
            this.txt_ogretmen_ismi.Name = "txt_ogretmen_ismi";
            this.txt_ogretmen_ismi.Size = new System.Drawing.Size(220, 31);
            this.txt_ogretmen_ismi.TabIndex = 5;
            // 
            // txt_tc_kimlik
            // 
            this.txt_tc_kimlik.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.txt_tc_kimlik.Location = new System.Drawing.Point(314, 252);
            this.txt_tc_kimlik.Name = "txt_tc_kimlik";
            this.txt_tc_kimlik.Size = new System.Drawing.Size(220, 31);
            this.txt_tc_kimlik.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label4.Location = new System.Drawing.Point(34, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "TC KİMLİK";
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.BackColor = System.Drawing.Color.Coral;
            this.btn_kaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.25F);
            this.btn_kaydet.Location = new System.Drawing.Point(83, 336);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(219, 81);
            this.btn_kaydet.TabIndex = 8;
            this.btn_kaydet.Text = "KAYDET";
            this.btn_kaydet.UseVisualStyleBackColor = false;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(654, 39);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(577, 399);
            this.listView1.TabIndex = 9;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1243, 450);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btn_kaydet);
            this.Controls.Add(this.txt_tc_kimlik);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_ogretmen_ismi);
            this.Controls.Add(this.txt_bolum);
            this.Controls.Add(this.txt_isim);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_isim;
        private System.Windows.Forms.TextBox txt_bolum;
        private System.Windows.Forms.TextBox txt_ogretmen_ismi;
        private System.Windows.Forms.TextBox txt_tc_kimlik;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_kaydet;
        private System.Windows.Forms.ListView listView1;
    }
}

