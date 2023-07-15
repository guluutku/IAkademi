namespace Der4_Toolbox
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
            this.rB_ilkOkul = new System.Windows.Forms.RadioButton();
            this.rB_universite = new System.Windows.Forms.RadioButton();
            this.rB_ortaOkul = new System.Windows.Forms.RadioButton();
            this.rB_lise = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.lbl_egitim = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rB_kadin = new System.Windows.Forms.RadioButton();
            this.rB_erkek = new System.Windows.Forms.RadioButton();
            this.lbl_cinsiyet = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // rB_ilkOkul
            // 
            this.rB_ilkOkul.AutoSize = true;
            this.rB_ilkOkul.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rB_ilkOkul.Location = new System.Drawing.Point(23, 84);
            this.rB_ilkOkul.Name = "rB_ilkOkul";
            this.rB_ilkOkul.Size = new System.Drawing.Size(136, 33);
            this.rB_ilkOkul.TabIndex = 0;
            this.rB_ilkOkul.TabStop = true;
            this.rB_ilkOkul.Text = "İLKOKUL";
            this.rB_ilkOkul.UseVisualStyleBackColor = true;
            // 
            // rB_universite
            // 
            this.rB_universite.AutoSize = true;
            this.rB_universite.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rB_universite.Location = new System.Drawing.Point(524, 84);
            this.rB_universite.Name = "rB_universite";
            this.rB_universite.Size = new System.Drawing.Size(180, 33);
            this.rB_universite.TabIndex = 1;
            this.rB_universite.TabStop = true;
            this.rB_universite.Text = "ÜNİVERSİTE";
            this.rB_universite.UseVisualStyleBackColor = true;
            // 
            // rB_ortaOkul
            // 
            this.rB_ortaOkul.AutoSize = true;
            this.rB_ortaOkul.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rB_ortaOkul.Location = new System.Drawing.Point(186, 84);
            this.rB_ortaOkul.Name = "rB_ortaOkul";
            this.rB_ortaOkul.Size = new System.Drawing.Size(168, 33);
            this.rB_ortaOkul.TabIndex = 2;
            this.rB_ortaOkul.TabStop = true;
            this.rB_ortaOkul.Text = "ORTAOKUL";
            this.rB_ortaOkul.UseVisualStyleBackColor = true;
            // 
            // rB_lise
            // 
            this.rB_lise.AutoSize = true;
            this.rB_lise.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rB_lise.Location = new System.Drawing.Point(387, 84);
            this.rB_lise.Name = "rB_lise";
            this.rB_lise.Size = new System.Drawing.Size(85, 33);
            this.rB_lise.TabIndex = 3;
            this.rB_lise.TabStop = true;
            this.rB_lise.Text = "LİSE";
            this.rB_lise.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 44);
            this.label1.TabIndex = 4;
            this.label1.Text = "EĞİTİM DURUMU";
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_kaydet.Location = new System.Drawing.Point(782, 515);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(217, 92);
            this.btn_kaydet.TabIndex = 5;
            this.btn_kaydet.Text = "KAYDET";
            this.btn_kaydet.UseVisualStyleBackColor = true;
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // lbl_egitim
            // 
            this.lbl_egitim.AutoSize = true;
            this.lbl_egitim.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_egitim.Location = new System.Drawing.Point(82, 435);
            this.lbl_egitim.Name = "lbl_egitim";
            this.lbl_egitim.Size = new System.Drawing.Size(158, 25);
            this.lbl_egitim.TabIndex = 6;
            this.lbl_egitim.Text = "EĞİTİM SONUÇ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 44);
            this.label2.TabIndex = 7;
            this.label2.Text = "CİNSİYET";
            // 
            // rB_kadin
            // 
            this.rB_kadin.AutoSize = true;
            this.rB_kadin.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rB_kadin.Location = new System.Drawing.Point(202, 126);
            this.rB_kadin.Name = "rB_kadin";
            this.rB_kadin.Size = new System.Drawing.Size(107, 33);
            this.rB_kadin.TabIndex = 9;
            this.rB_kadin.TabStop = true;
            this.rB_kadin.Text = "KADIN";
            this.rB_kadin.UseVisualStyleBackColor = true;
            // 
            // rB_erkek
            // 
            this.rB_erkek.AutoSize = true;
            this.rB_erkek.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rB_erkek.Location = new System.Drawing.Point(39, 126);
            this.rB_erkek.Name = "rB_erkek";
            this.rB_erkek.Size = new System.Drawing.Size(117, 33);
            this.rB_erkek.TabIndex = 8;
            this.rB_erkek.TabStop = true;
            this.rB_erkek.Text = "ERKEK";
            this.rB_erkek.UseVisualStyleBackColor = true;
            // 
            // lbl_cinsiyet
            // 
            this.lbl_cinsiyet.AutoSize = true;
            this.lbl_cinsiyet.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cinsiyet.Location = new System.Drawing.Point(296, 435);
            this.lbl_cinsiyet.Name = "lbl_cinsiyet";
            this.lbl_cinsiyet.Size = new System.Drawing.Size(182, 25);
            this.lbl_cinsiyet.TabIndex = 10;
            this.lbl_cinsiyet.Text = "CİNSİYET SONUÇ";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Chartreuse;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.rB_lise);
            this.groupBox1.Controls.Add(this.rB_ortaOkul);
            this.groupBox1.Controls.Add(this.rB_universite);
            this.groupBox1.Controls.Add(this.rB_ilkOkul);
            this.groupBox1.Location = new System.Drawing.Point(46, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(720, 163);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Eğitim Grup";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.BurlyWood;
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.rB_erkek);
            this.groupBox2.Controls.Add(this.rB_kadin);
            this.groupBox2.Location = new System.Drawing.Point(46, 192);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(354, 191);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cinsiyet Grup";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 634);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbl_cinsiyet);
            this.Controls.Add(this.lbl_egitim);
            this.Controls.Add(this.btn_kaydet);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rB_ilkOkul;
        private System.Windows.Forms.RadioButton rB_universite;
        private System.Windows.Forms.RadioButton rB_ortaOkul;
        private System.Windows.Forms.RadioButton rB_lise;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_kaydet;
        private System.Windows.Forms.Label lbl_egitim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rB_kadin;
        private System.Windows.Forms.RadioButton rB_erkek;
        private System.Windows.Forms.Label lbl_cinsiyet;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

