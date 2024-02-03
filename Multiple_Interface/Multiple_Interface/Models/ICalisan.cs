using System;
namespace Multiple_Interface.Models
{
	public interface ICalisan
	{

		// Ortak
		int ID { get; set; }
		string Departman { get; set; }
		ulong ToplamCalismaSaati { get; set; }
		void insert();

	}
}

