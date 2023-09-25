using NTierDesign_KatmanliMimari.DataLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierDesign_KatmanliMimari.BusinessLayer
{
    public class Cls_Product
    {
        public string ProductName { get; set; }
        public int UnitsInStock { get; set; }
        public decimal UnitPrice { get; set; }
        public int CategoryID { get; set; }
        public int SupplierID { get; set; }

        public bool Save()
        {
            try
            {
                SqlConnection sqlCon = Connection.baglanti;
                SqlCommand sqlCmd = new SqlCommand("sp_urun_insert", sqlCon);
                sqlCmd.CommandType = System.Data.CommandType.StoredProcedure;

                sqlCmd.Parameters.AddWithValue("@ProductName", ProductName);
                sqlCmd.Parameters.AddWithValue("@UnitsInStock", UnitsInStock);
                sqlCmd.Parameters.AddWithValue("@UnitPrice", UnitPrice);
                sqlCmd.Parameters.AddWithValue("@CategoryID", CategoryID);
                sqlCmd.Parameters.AddWithValue("@SupplierID", SupplierID);

                sqlCon.Open();
                sqlCmd.ExecuteNonQuery();
                sqlCon.Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public SqlDataReader SelectByProductName() 
        {
            try
            {
                SqlConnection sqlCon = Connection.baglanti;
                SqlCommand sqlCmd = new SqlCommand("SELECT * FROM vw_urunleri_listele", sqlCon);
                sqlCon.Open();
                SqlDataReader sdr = sqlCmd.ExecuteReader();
                return sdr;

            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public SqlDataReader SearchByProductName(string ProductName)
        {
            try
            {
                SqlConnection sqlCon = Connection.baglanti;
                SqlCommand command = new SqlCommand
                    ("select * from Products where ProductName like '%" + ProductName + "%'", sqlCon);

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
