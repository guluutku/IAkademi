using System;
namespace Multiple_Interface.Models
{
	public interface IKisi
	{

		// Sadece canlılar
		string AdSoyad { get; set; }
		string Adres { get; set; }
		decimal Maas { get; set; }

    }
}
