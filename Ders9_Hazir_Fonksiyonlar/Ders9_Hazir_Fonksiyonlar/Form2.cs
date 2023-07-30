using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders9_Hazir_Fonksiyonlar
{
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            textBox1.Text = "Gün ULU";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // İlk bulunan ü'nün indexini veriyor
            // label1.Text = textBox1.Text.IndexOf("ü").ToString();
            // label1.Text = IndexOf(textBox1.Text, 'ü').ToString();

            // 3. indexten sonra kelime ekle
            // label1.Text = textBox1.Text.Insert(3, "yeni").ToString();

            // Kelimenin içindeki karakter sayısı
            // int count = textBox1.Text.Length;
            // label1.Text = count + " tane karakter var.";

            // 1. indexten, 4 karakter sil
            // label1.Text = textBox1.Text.Remove(1, 4);

            // seçili karakterleri değiştir
            // Büyük-küçük harf duyarlılığı var
            // label1.Text = textBox1.Text.Replace("U", "X");
        }

        public sbyte IndexOf(string aranacakAlan, char c)
        {
            int index = 0;
            for (int i = 0; i < aranacakAlan.Length; i++)
            {
                if (aranacakAlan[i] == c)
                {
                    index = i;
                }
                else
                {
                    index = -1;
                }
            }
            return Convert.ToSByte(index);
        }
    }
}
