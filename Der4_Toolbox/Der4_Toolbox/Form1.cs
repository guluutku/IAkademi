using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Der4_Toolbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            // eğitim seçenekleri
            if (rB_ilkOkul.Checked)
            {
                // ilkokul tıklandı
                lbl_egitim.Text = "ilkokul";
            }
            else if (rB_ortaOkul.Checked)
            {
                // ortaokul tıklandı
                lbl_egitim.Text = "ortaokul";
            }
            else if (rB_lise.Checked)
            {
                // lise tıklandı
                lbl_egitim.Text = "lise";
            }
            else
            {
                // üniversite tıklandı
                lbl_egitim.Text = "üniversite";
            }

            // cinsiyet seçenekleri
            if (rB_erkek.Checked)
            {
                // erkek tıklandı
                lbl_cinsiyet.Text = "erkek";
            }
            else if (rB_kadin.Checked)
            {
                // kadın tıklandı
                lbl_cinsiyet.Text = "kadın";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // rB_lise.Checked = true;
        }
    }
}
