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
            this.SuspendLayout();
            // 
            // rB_ilkOkul
            // 
            this.rB_ilkOkul.AutoSize = true;
            this.rB_ilkOkul.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rB_ilkOkul.Location = new System.Drawing.Point(74, 103);
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
            this.rB_universite.Location = new System.Drawing.Point(575, 103);
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
            this.rB_ortaOkul.Location = new System.Drawing.Point(237, 103);
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
            this.rB_lise.Location = new System.Drawing.Point(438, 103);
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
            this.label1.Location = new System.Drawing.Point(79, 28);
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
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 634);
            this.Controls.Add(this.btn_kaydet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rB_lise);
            this.Controls.Add(this.rB_ortaOkul);
            this.Controls.Add(this.rB_universite);
            this.Controls.Add(this.rB_ilkOkul);
            this.Name = "Form1";
            this.Text = "Form1";
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
    }
}

