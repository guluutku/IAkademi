namespace Ders8_Timer
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
            this.components = new System.ComponentModel.Container();
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_stop = new System.Windows.Forms.Button();
            this.lbl_zaman = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txt_guncelle = new System.Windows.Forms.TextBox();
            this.btn_sure_guncelle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_start
            // 
            this.btn_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.btn_start.Location = new System.Drawing.Point(116, 320);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(165, 70);
            this.btn_start.TabIndex = 0;
            this.btn_start.Text = "START";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // btn_stop
            // 
            this.btn_stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.btn_stop.Location = new System.Drawing.Point(410, 320);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(165, 70);
            this.btn_stop.TabIndex = 1;
            this.btn_stop.Text = "STOP";
            this.btn_stop.UseVisualStyleBackColor = true;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // lbl_zaman
            // 
            this.lbl_zaman.AutoSize = true;
            this.lbl_zaman.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.25F);
            this.lbl_zaman.Location = new System.Drawing.Point(268, 116);
            this.lbl_zaman.Name = "lbl_zaman";
            this.lbl_zaman.Size = new System.Drawing.Size(121, 44);
            this.lbl_zaman.TabIndex = 2;
            this.lbl_zaman.Text = "label1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txt_guncelle
            // 
            this.txt_guncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.txt_guncelle.Location = new System.Drawing.Point(692, 130);
            this.txt_guncelle.Name = "txt_guncelle";
            this.txt_guncelle.Size = new System.Drawing.Size(151, 35);
            this.txt_guncelle.TabIndex = 3;
            // 
            // btn_sure_guncelle
            // 
            this.btn_sure_guncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.btn_sure_guncelle.Location = new System.Drawing.Point(643, 320);
            this.btn_sure_guncelle.Name = "btn_sure_guncelle";
            this.btn_sure_guncelle.Size = new System.Drawing.Size(344, 70);
            this.btn_sure_guncelle.TabIndex = 4;
            this.btn_sure_guncelle.Text = "SÜRE GÜNCELLE";
            this.btn_sure_guncelle.UseVisualStyleBackColor = true;
            this.btn_sure_guncelle.Click += new System.EventHandler(this.btn_sure_guncelle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 450);
            this.Controls.Add(this.btn_sure_guncelle);
            this.Controls.Add(this.txt_guncelle);
            this.Controls.Add(this.lbl_zaman);
            this.Controls.Add(this.btn_stop);
            this.Controls.Add(this.btn_start);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.Label lbl_zaman;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txt_guncelle;
        private System.Windows.Forms.Button btn_sure_guncelle;
    }
}

