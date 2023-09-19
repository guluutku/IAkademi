using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders35_Okul38Proje
{
    public class Connection
    {
        public static SqlConnection baglanti 
        {
            get
            {
                SqlConnection sqlConnection = new SqlConnection("Server=DESKTOP-HCLM2KF;Trusted_Connection=True;Database=okul38DB;");
                return sqlConnection;
            }
        }
    }
}
