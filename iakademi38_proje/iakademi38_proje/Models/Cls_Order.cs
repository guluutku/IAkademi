using System;

namespace iakademi38_proje.Models
{
	public class Cls_Order
	{

        iakademi38Context context = new  iakademi38Context();

        public int ProductID { get; set; }
        public int Quantity { get; set; }
		public string? MyCart { get; set; }

		public decimal UnitPrice { get; set; }
		public string? ProductName { get; set; }
		public int Kdv { get; set; }
		public string? PhotoPath { get; set; }
		public string? tckimlik_vergi_no { get; set; }


        #region sepete ekle
            // sepete ekle
            // projede herhangi bir sayfada ürünü sepete ekle buton'u tıklanınca
        #endregion
        public bool AddToMyCart(string id)
        {
            bool exist = false;

            if (MyCart == "")
            {
                // Sepete ilk defa ürün eklenecek
                MyCart = id + "=1";
                exist = true;
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

        public void DeleteFromMyCart(string? id)
        {
            string[] MyCartArray = MyCart!.Split('&'); // ürünleri birbirinden ayır
            string NewMyCart = "";
            int count = 1;

            for (int i = 0; i < MyCartArray.Length; i++)
            {
                string[] MyCartArrayLoop = MyCartArray[i].Split('=');
                // her döndüğünde dizinin sıfırıncı alanındaki değeri(ProductID) MyCartID ye ata
                string MyCartID = MyCartArrayLoop[0];
                if(MyCartID != id)
                {
                    // silinmeyecek ürünleri yeni sepete at
                    if (count == 1)
                    {
                        // sepette 1 ürün var
                        // '&' işareti eklenmeyecek
                        NewMyCart = MyCartArrayLoop[0] + '=' + MyCartArrayLoop[1];
                        count++;
                    }
                    else
                    {
                        // sepette 1'den fazla ürün var
                        // '&' işareti eklenecek
                        NewMyCart += '&' + MyCartArrayLoop[0] + '=' + MyCartArrayLoop[1];
                    }
                }
            }

            MyCart = NewMyCart;
        }

        public List<Cls_Order> SelectMyCart()
        {
            List<Cls_Order> orders = new List<Cls_Order>();
            string[] MyCartArray = MyCart!.Split('&');

            if (MyCartArray[0] != "")
            {
                for (int i = 0; i < MyCartArray.Length; i++)
                {
                    string[] MyCartArrayLoop = MyCartArray[i].Split('=');
                    int MyCartID = Convert.ToInt32(MyCartArrayLoop[0]);

                    Product? product = context.Products.FirstOrDefault(p => p.ProductID == MyCartID);
                    Cls_Order ord = new Cls_Order();

                    ord.ProductID = product!.ProductID;
                    ord.Quantity = Convert.ToInt32(MyCartArrayLoop[1]);
                    ord.UnitPrice = product.UnitPrice;
                    ord.ProductName = product.ProductName;
                    ord.PhotoPath = product.PhotoPath;
                    ord.Kdv = product.Kdv;
                    orders.Add(ord);
                }
            }
            else
            {

            }

            return orders;
        }

        public void EfaturaCreate()
        {
            //digital planet xml dosyası
        }

    }

}
