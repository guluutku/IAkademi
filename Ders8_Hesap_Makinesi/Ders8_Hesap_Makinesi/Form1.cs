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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double value = 0;
        string operation = "";
        bool operation_pressed = false;

        private void btn_number_click(object sender, EventArgs e)
        {

            if (txt_result.Text == "0" || operation_pressed)
            {
                txt_result.Clear();
            }

            Button btn = sender as Button; // ConvertToButton(sender) / 1. yol
            // Button btn = (Button)sender; // ConvertToButton(sender) / 2. yol
            txt_result.Text = txt_result.Text + btn.Text;
            operation_pressed = false;
        }

        private void btn_operation_click(object sender, EventArgs e)
        {
            char lastChar = txt_result.Text.Last();
            char firstChar = txt_result.Text.First();
            if (lastChar == '.' || firstChar == '.')
            {
                MessageBox.Show("First And Last Character Must be a Number");
                return;
            }
            Button btn = sender as Button;
            operation = btn.Text;
            operation_pressed = true;
            value = double.Parse(txt_result.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_ce_Click(object sender, EventArgs e)
        {
            txt_result.Clear();
        }

        private void btn_c_Click(object sender, EventArgs e)
        {
            txt_result.Clear();
            value = 0;
        }

        private void btn_equation_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                default:
                    break;
                case "+":
                    txt_result.Text = (value + double.Parse(txt_result.Text)).ToString();
                    break;
                case "-":
                    txt_result.Text = (value - double.Parse(txt_result.Text)).ToString();
                    break;
                case "*":
                    txt_result.Text = (value * double.Parse(txt_result.Text)).ToString();
                    break;
                case "/":
                    txt_result.Text = (value / double.Parse(txt_result.Text)).ToString();
                    break;
            }
        }
    }
}
