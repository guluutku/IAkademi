namespace WindowsFormsApp1
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
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBIsim = new System.Windows.Forms.TextBox();
            this.txtBxSoyisim = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBYas = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBAdres = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_ogrenci_id = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.BackColor = System.Drawing.Color.Chartreuse;
            this.btn_kaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_kaydet.Location = new System.Drawing.Point(64, 503);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(365, 69);
            this.btn_kaydet.TabIndex = 0;
            this.btn_kaydet.Text = "Kaydet";
            this.btn_kaydet.UseVisualStyleBackColor = false;
            this.btn_kaydet.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(157, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(461, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "ÖĞRENCİ KAYIT FORMU";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "İsim Giriniz:";
            this.label2.UseMnemonic = false;
            // 
            // txtBIsim
            // 
            this.txtBIsim.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBIsim.Location = new System.Drawing.Point(251, 116);
            this.txtBIsim.Name = "txtBIsim";
            this.txtBIsim.Size = new System.Drawing.Size(243, 35);
            this.txtBIsim.TabIndex = 3;
            // 
            // txtBxSoyisim
            // 
            this.txtBxSoyisim.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxSoyisim.Location = new System.Drawing.Point(251, 183);
            this.txtBxSoyisim.Name = "txtBxSoyisim";
            this.txtBxSoyisim.Size = new System.Drawing.Size(243, 35);
            this.txtBxSoyisim.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(59, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Soyisim Giriniz:";
            this.label3.UseMnemonic = false;
            // 
            // txtBYas
            // 
            this.txtBYas.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBYas.Location = new System.Drawing.Point(251, 235);
            this.txtBYas.Name = "txtBYas";
            this.txtBYas.Size = new System.Drawing.Size(243, 35);
            this.txtBYas.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(59, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "Yaş Giriniz:";
            this.label4.UseMnemonic = false;
            // 
            // txtBAdres
            // 
            this.txtBAdres.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBAdres.Location = new System.Drawing.Point(251, 285);
            this.txtBAdres.Multiline = true;
            this.txtBAdres.Name = "txtBAdres";
            this.txtBAdres.Size = new System.Drawing.Size(243, 29);
            this.txtBAdres.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(59, 285);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 29);
            this.label5.TabIndex = 8;
            this.label5.Text = "Adres Giriniz:";
            this.label5.UseMnemonic = false;
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_guncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guncelle.Location = new System.Drawing.Point(607, 503);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(388, 69);
            this.btn_guncelle.TabIndex = 10;
            this.btn_guncelle.Text = "Güncelle";
            this.btn_guncelle.UseVisualStyleBackColor = false;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(59, 341);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 29);
            this.label6.TabIndex = 11;
            this.label6.Text = "Öğrenci ID:";
            // 
            // txt_ogrenci_id
            // 
            this.txt_ogrenci_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ogrenci_id.Location = new System.Drawing.Point(251, 341);
            this.txt_ogrenci_id.Multiline = true;
            this.txt_ogrenci_id.Name = "txt_ogrenci_id";
            this.txt_ogrenci_id.Size = new System.Drawing.Size(243, 29);
            this.txt_ogrenci_id.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1094, 634);
            this.Controls.Add(this.txt_ogrenci_id);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_guncelle);
            this.Controls.Add(this.txtBAdres);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBYas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBxSoyisim);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBIsim);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_kaydet);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_kaydet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBIsim;
        private System.Windows.Forms.TextBox txtBxSoyisim;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBYas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBAdres;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_guncelle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_ogrenci_id;
    }
}

