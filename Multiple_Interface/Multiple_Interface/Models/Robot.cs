using System;
namespace Multiple_Interface.Models
{
	public class Robot : ICalisan
	{
		public Robot()
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

        void ICalisan.insert()
        {
            throw new NotImplementedException();
        }
    }
}

