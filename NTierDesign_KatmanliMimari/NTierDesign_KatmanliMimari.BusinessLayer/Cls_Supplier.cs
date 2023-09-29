using NTierDesign_KatmanliMimari.DataLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierDesign_KatmanliMimari.BusinessLayer
{
    public class Cls_Supplier
    {
        public string CompanyName
        {
            get
            {
                return _CompanyNameUpper;
            }
            set
            {
                _CompanyNameUpper = value.ToUpper();
            }
        }
        public string ContactName { get; set; }
        public int SupplierID { get; set; }

        private string _CompanyNameUpper
        {
            get; set;
        }

        public bool Save()
        {
            try
            {
                SqlConnection sqlCon = Connection.baglanti;

                SqlCommand command = new SqlCommand
                    ("insert into Suppliers(CompanyName, ContactName)" +
                    "\r\nvalues(@CompanyName, @ContactName)", sqlCon);

                command.Parameters.AddWithValue("@CompanyName", _CompanyNameUpper);
                command.Parameters.AddWithValue("@ContactName", ContactName);

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

        public SqlDataReader PartialSuppliersList()
        {
            try
            {
                SqlConnection sqlCon = Connection.baglanti;

                SqlCommand command = new SqlCommand
                    ("SELECT * FROM vw_supplier_kismi_listele", sqlCon);

                sqlCon.Open();

                SqlDataReader sdr = command.ExecuteReader();

                return sdr;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public SqlDataReader SearchByCompanyName(string searchName)
        {
            try
            {
                SqlConnection sqlCon = Connection.baglanti;
                SqlCommand command = new SqlCommand("select SupplierID, CompanyName, ContactName from Suppliers " +
                    "where CompanyName like '%" + searchName + "%'", sqlCon);

                sqlCon.Open();

                SqlDataReader sdr = command.ExecuteReader();

                return sdr;
            } 
            catch (Exception ex)
            {
                return null;
            }
        }

        public bool Update()
        {
            try
            {
                SqlConnection sqlCon = Connection.baglanti;
                SqlCommand sqlCmd = new SqlCommand("sp_update_supplier", sqlCon);
                sqlCmd.CommandType = System.Data.CommandType.StoredProcedure;

                sqlCmd.Parameters.AddWithValue("@SupplierID", SupplierID);
                sqlCmd.Parameters.AddWithValue("@CompanyName", CompanyName);
                sqlCmd.Parameters.AddWithValue("@ContactName", ContactName);

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

        public bool Delete()
        {
            try
            {
                SqlConnection sqlCon = Connection.baglanti;
                SqlCommand sqlCmd = new SqlCommand("sp_delete_supplier", sqlCon);
                sqlCmd.CommandType = System.Data.CommandType.StoredProcedure;

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

    }
}
