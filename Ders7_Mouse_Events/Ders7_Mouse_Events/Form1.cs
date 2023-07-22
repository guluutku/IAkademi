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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // click events: klavyenin ve farenin tuşlarının tıklanmamsıdır
        // down olduğunda basılınca çalışır
        // up olduğunda bıraktığında çalışır
        // click = down + up
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            // MessageBox.Show("Form1 mouse down");

            if (e.Button == MouseButtons.Left)
            {
                button1.BackColor = Color.Red;
                // MessageBox.Show("Sol Basıldı");
            }
            else
            {
                button1.BackColor = Color.Green;
                // MessageBox.Show("Sağ Basıldı");
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            button1.BackColor = Color.Blue;
            // MessageBox.Show("Mouse Up");
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            // MessageBox.Show("Fare hareket etti");
        }


    }
}
