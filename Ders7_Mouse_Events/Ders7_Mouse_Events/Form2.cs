using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders7_Mouse_Events
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // btnKaydet.Visible = false;
        }

        private void textBox1_MouseDown(object sender, MouseEventArgs e)
        {
            textBox1.BackColor = Color.Green;
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (textBox1.Text.Length >= 2)
            {
                btnKaydet.Visible = true;
            }
            else
            {
                btnKaydet.Visible = false;
            }
        }

        private void btn_guncelle_MouseHover(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
            btn_guncelle.BackColor = Color.Green;
        }

        private void btn_guncelle_MouseLeave(object sender, EventArgs e)
        {
            btn_guncelle.BackColor = Color.Red;
            this.BackColor = Color.White;
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            // MessageBox.Show("Kapatmak istediğinizden emin misiniz?");
            if (MessageBox.Show("Kapatmak istediğinizden emin misiniz?", "Form2 kapatma işlem", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                // "No" butonu tıklandı
                // İşlem iptal
                // MessageBox.Show("İptal Edildi");
                e.Cancel = true;
            }
            else
            {
                // MessageBox.Show("Kapatılıyor");
                this.Hide();
            }
        }
    }
}
