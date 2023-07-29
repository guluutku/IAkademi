namespace Ders8_Hesap_Makinesi
{
    partial class frmProcess
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
            this.btn_windows = new System.Windows.Forms.Button();
            this.btn_iakademi = new System.Windows.Forms.Button();
            this.process1 = new System.Diagnostics.Process();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btn_windows
            // 
            this.btn_windows.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.btn_windows.Location = new System.Drawing.Point(89, 60);
            this.btn_windows.Name = "btn_windows";
            this.btn_windows.Size = new System.Drawing.Size(402, 105);
            this.btn_windows.TabIndex = 0;
            this.btn_windows.Text = "WİNDOWS HESAP MAKİNESİ";
            this.btn_windows.UseVisualStyleBackColor = true;
            this.btn_windows.Click += new System.EventHandler(this.btn_windows_Click);
            // 
            // btn_iakademi
            // 
            this.btn_iakademi.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.btn_iakademi.Location = new System.Drawing.Point(580, 60);
            this.btn_iakademi.Name = "btn_iakademi";
            this.btn_iakademi.Size = new System.Drawing.Size(402, 105);
            this.btn_iakademi.TabIndex = 0;
            this.btn_iakademi.Text = "İAKADEMİ HESAP MAKİNESİ";
            this.btn_iakademi.UseVisualStyleBackColor = true;
            this.btn_iakademi.Click += new System.EventHandler(this.btn_iakademi_Click);
            // 
            // process1
            // 
            this.process1.StartInfo.Domain = "";
            this.process1.StartInfo.LoadUserProfile = false;
            this.process1.StartInfo.Password = null;
            this.process1.StartInfo.StandardErrorEncoding = null;
            this.process1.StartInfo.StandardOutputEncoding = null;
            this.process1.StartInfo.UserName = "";
            this.process1.SynchronizingObject = this;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(379, 544);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(318, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(406, 224);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(248, 303);
            this.listBox1.TabIndex = 2;
            // 
            // frmProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 707);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_iakademi);
            this.Controls.Add(this.btn_windows);
            this.Name = "frmProcess";
            this.Text = "frmProcess";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_windows;
        private System.Windows.Forms.Button btn_iakademi;
        private System.Diagnostics.Process process1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listBox1;
    }
}