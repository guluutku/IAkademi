using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierDesign_KatmanliMimari.DataLayer
{
    public class Connection
    {
        public static SqlConnection baglanti
        {
            get
            {
                SqlConnection sqlConnection = new SqlConnection("Server=DESKTOP-HCLM2KF;Trusted_Connection=True;Database=NORTHWND;");
                return sqlConnection;
            }
        }
    }
}
