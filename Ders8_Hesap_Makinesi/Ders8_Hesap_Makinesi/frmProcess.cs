using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders8_Hesap_Makinesi
{
    public partial class frmProcess : Form
    {
        public frmProcess()
        {
            InitializeComponent();
        }

        private void btn_windows_Click(object sender, EventArgs e)
        {
            process1.StartInfo.FileName = "calc.exe";
            process1.Start();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
        }

        private void btn_iakademi_Click(object sender, EventArgs e)
        {
           // how to open custom .exe file
           process1.StartInfo.FileName = "D:\\Projeler\\VisulaStudio\\IAkademi\\Ders8_Hesap_Makinesi\\Ders8_Hesap_Makinesi\\bin\\Debug\\Ders8_Hesap_Makinesi.exe";

            process1.Start();
        }
    }
}
