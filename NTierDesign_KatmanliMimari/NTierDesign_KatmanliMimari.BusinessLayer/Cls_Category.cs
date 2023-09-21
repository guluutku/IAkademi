using NTierDesign_KatmanliMimari.DataLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierDesign_KatmanliMimari.BusinessLayer
{
    public class Cls_Category
    {
        public static bool Save(string CategoryName, string Description)
        {
            try
            {
                SqlConnection sqlCon = Connection.baglanti;
                SqlCommand command = new SqlCommand
                    ("insert into Categories(CategoryName, Description)" +
                    "\r\nvalues(@CategoryName, @Description)", sqlCon);
                command.Parameters.AddWithValue("@CategoryName", CategoryName);
                command.Parameters.AddWithValue("@Description", Description);
                sqlCon.Open();
                command.ExecuteNonQuery();
                sqlCon.Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public SqlDataReader SelectByCategoryName()
        {
            try
            {
                SqlConnection sqlCon = Connection.baglanti;
                SqlCommand command = new SqlCommand
                    ("SELECT * FROM vw_kategori_kismi_listesi", sqlCon);
               
                sqlCon.Open();

                SqlDataReader sdr = command.ExecuteReader();

                return sdr;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
