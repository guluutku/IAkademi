using System;
namespace Multiple_Interface.Models
{
	public class Isci : ICalisan, IKisi
	{
		public Isci()
		{
		}

        int ICalisan.ID
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        string ICalisan.Departman
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        ulong ICalisan.ToplamCalismaSaati
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        string IKisi.AdSoyad
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        string IKisi.Adres
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        decimal IKisi.Maas
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        void ICalisan.insert()
        {
            throw new NotImplementedException();
        }
    }
}

