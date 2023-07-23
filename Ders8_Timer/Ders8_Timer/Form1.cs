using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders8_Timer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_zaman.Text = DateTime.Now.ToString();
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void btn_sure_guncelle_Click(object sender, EventArgs e)
        {
            timer1.Interval = Convert.ToInt32(txt_guncelle.Text);
        }
    }
}
