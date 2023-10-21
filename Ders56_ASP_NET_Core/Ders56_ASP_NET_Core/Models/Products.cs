using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ders56_ASP_NET_Core.Models
{
	public class Products
	{
		public Products()
		{
		}

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Set Primary key
		public int ProductID { get; set;}

		[Required]
        public string ProductName { get; set; }

    }
}

