using _09_07_lesson.classes;
using _09_07_lesson.forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _09_07_lesson
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Cls_Ogrenci cls = new Cls_Ogrenci();
            Cls_Ogrenci cls2 = new Cls_Ogrenci(4);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DetayFormu detayFormu = new DetayFormu(Convert.ToInt32(textBox1.Text));
            detayFormu.ShowDialog();
        }
    }
}
