using System;
namespace iakademi38_proje.Models
{
	public class Cls_Order
	{

		public Cls_Order()
		{
		}

        public int ProductID { get; set; }
        public int Quantity { get; set; }

		public string MyCart { get; set; }

        #region sepete ekle
            // sepete ekle
            // projede herhangi bir sayfada ürünü sepete ekle buton'u tıklanınca
        #endregion
        public bool AddToMyCart(string id)
        {
            bool exist = false;

            if (MyCart == null)
            {
                // Sepete ilk defa ürün eklenecek
                MyCart = id + "=1";
            }
            else
            {
                string[] MyCartArray = MyCart.Split('&'); // ürünleri birbirinden ayır
                for (int i = 0; i < MyCartArray.Length; i++)
                {
                    string[] MyCartArrayLoop = MyCartArray[i].Split('=');
                    if (MyCartArrayLoop[0] == id)
                    {
                        exist = true; // ürün sepete daha önce eklenmiş
                    }
                }
            }
            if(exist == false)
            {
                MyCart = MyCart + "&" + id.ToString() + "=1";
            }

            return exist;
        }
    }
}

