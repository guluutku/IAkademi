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

        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }

        NORTHWNDEntities entities = new NORTHWNDEntities(); 

        public static bool Save(Categories categories)
        {
            try
            {
                using(NORTHWNDEntities entities = new NORTHWNDEntities())
                {
                    entities.Categories.Add(categories);
                    entities.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public List<vw_kategori_kismi_listesi> SelectByCategoryName()
        {
            try
            {
                List<vw_kategori_kismi_listesi> kategori_Kismi_Listesi = entities.vw_kategori_kismi_listesi.ToList();
                return kategori_Kismi_Listesi;
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
                // Veritabanındaki eski verşye ulaşıyorum
                Categories categories = entities.Categories.FirstOrDefault(c => c.CategoryID == CategoryID);

                // eski verileri yeni veriler ile değiştir
                categories.CategoryName = CategoryName;
                categories.Description = CategoryDescription;
                entities.SaveChanges();
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
                entities.sp_category_delete(CategoryID);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }/*
              * Without using stored procedure
            try
            {
                Categories categories = entities.Categories.FirstOrDefault(c => c.CategoryID == CategoryID);
                entities.Categories.Remove(categories);
                entities.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
            */
        }
    }
}
