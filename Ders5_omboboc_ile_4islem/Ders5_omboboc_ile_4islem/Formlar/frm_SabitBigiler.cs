﻿using Ders5_omboboc_ile_4islem.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders5_omboboc_ile_4islem.Formlar
{
    public partial class frm_SabitBigiler : Form
    {
        public frm_SabitBigiler()
        {
            InitializeComponent();
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            cls_Ortak ortak = new cls_Ortak();
            ortak.telefon_no_kaydet(txt_telefonNo.Text);
        }
    }
}
