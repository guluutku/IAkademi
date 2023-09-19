using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders35_Okul38Proje
{
    public partial class frmOgrenciGiris : Form
    {
        public frmOgrenciGiris()
        {
            InitializeComponent();
        }

        private void btnKayder_Click(object sender, EventArgs e)
        {
           
            try
            {
                SqlConnection sqlCon = Connection.baglanti;
                SqlCommand command = new SqlCommand
                    ("insert into Ogrenci(Adi, Soyadi, Telefon, Yas)" +
                    "\r\nvalues(@Adi, @Soyadi, @Telefon, @Yas)", sqlCon);
                command.Parameters.AddWithValue("@Adi", txtAd.Text);
                command.Parameters.AddWithValue("@Soyadi", txtSoyad.Text);
                command.Parameters.AddWithValue("@Telefon", txtTelefon.Text);
                command.Parameters.AddWithValue("@Yas", txtYas.Text);
                sqlCon.Open();
                command.ExecuteNonQuery();
                sqlCon.Close();
                MessageBox.Show("Kaydedildi");
            } catch (Exception ex) { 
                MessageBox.Show("Hata");
            }
        }
    }
}
