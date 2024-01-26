using System;
using Microsoft.Data.SqlClient;

namespace iakademi38_proje.Models
{
	public class Connection
	{

		public Connection()
		{
		}

		public static SqlConnection ServerConnect
		{
            get
			{
				SqlConnection sqlConnection = new SqlConnection("Server=localhost;Database=iakademi38Core_proje;User Id=SA;Password=S3rv3r97;TrustServerCertificate=True");
				return sqlConnection;
			}
		}

	}
}
