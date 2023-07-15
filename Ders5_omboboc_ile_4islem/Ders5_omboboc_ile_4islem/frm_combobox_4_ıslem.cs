using Ders5_omboboc_ile_4islem.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders5_omboboc_ile_4islem
{
    public partial class frm_combobox_4_ıslem : Form
    {
        public frm_combobox_4_ıslem()
        {
            InitializeComponent();
        }

        private void frm_combobox_4_ıslem_Load(object sender, EventArgs e)
        {
            // Dizayndan yapılamıyacak kısımlar eklenir
            // Dizaynda yapmak yerine kod kısmında gerçekleştir
            // Dinamik olması için dizayn yerine kod kullan
            cmb_process.Items.Add("TOPLAMA");
            cmb_process.Items.Add("ÇIKARMA");
            cmb_process.Items.Add("ÇARPMA");
            cmb_process.Items.Add("BÖLME");

            cls_Ortak ortak = new cls_Ortak();
            lbl_telefonNo.Text = ortak.telefon_no_getir();
        }

        private void btn_hesapla_Click(object sender, EventArgs e)
        {
            int birinci_sayi = Convert.ToInt32(txt_firstNumber.Text);
            int ikinci_sayi = Convert.ToInt32(txt_secondNumber.Text);
            switch (cmb_process.SelectedItem)
            {
                case "TOPLAMA":
                    lbl_sonuc.Text = Convert.ToString(birinci_sayi + ikinci_sayi);
                    break;

                case "ÇIKARMA":
                    break;

                case "ÇARPMA":
                    lbl_sonuc.Text = Convert.ToString(birinci_sayi * ikinci_sayi);
                    break;

                case "BÖLME":
                    break;
            }
        }
    }
}
