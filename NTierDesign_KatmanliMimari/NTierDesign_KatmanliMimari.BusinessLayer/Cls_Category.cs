﻿using NTierDesign_KatmanliMimari.DataLayer;
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

        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }

        public static bool Save(string CategoryName, string Description)
        {
            try
            {
                SqlConnection sqlCon = Connection.baglanti;
                SqlCommand command = new SqlCommand("sp_category_insert", sqlCon);
                command.CommandType = System.Data.CommandType.StoredProcedure;

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

        public SqlDataReader SearchByCategoryName(string CategoryName)
        {
            try
            {
                SqlConnection sqlCon = Connection.baglanti;
                SqlCommand command = new SqlCommand
                    ("select * from Categories where CategoryName like '%"+ CategoryName +"%'", sqlCon);

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
                SqlCommand sqlCmd = new SqlCommand("sp_category_update", sqlCon);
                sqlCmd.CommandType = System.Data.CommandType.StoredProcedure;

                sqlCmd.Parameters.AddWithValue("@CategoryName", CategoryName);
                sqlCmd.Parameters.AddWithValue("@Description", CategoryDescription );
                sqlCmd.Parameters.AddWithValue("@CategoryID", CategoryID);
                
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
                SqlCommand sqlCmd = new SqlCommand("sp_category_delete", sqlCon);
                sqlCmd.CommandType = System.Data.CommandType.StoredProcedure;

                sqlCmd.Parameters.AddWithValue("@CategoryID", CategoryID);

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
