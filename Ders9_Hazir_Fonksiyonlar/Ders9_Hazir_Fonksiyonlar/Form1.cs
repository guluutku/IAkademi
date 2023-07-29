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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // küçüğe yuvarla
            textBox1.Text = Math.Floor(Convert.ToDecimal(textBox1.Text)).ToString();

            // büyk olanı bul
            // textBox1.Text = Math.Max(100, 200).ToString();

            // küçük olanı bul
            // textBox1.Text = Math.Min(100, 200).ToString();

            // Math.Abs = mutlak değer = sayının pozitif hali
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // büyüğe yuvarlama
            textBox1.Text = Math.Ceiling(Convert.ToDecimal(textBox1.Text)).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // 5'ten büyükse yukarı, 5'ten küçükse aşağı
            textBox1.Text = Math.Round(Convert.ToDecimal(textBox1.Text)).ToString();
        }
    }
}
