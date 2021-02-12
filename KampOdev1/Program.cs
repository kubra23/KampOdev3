using System;

namespace KampOdev1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Adi = "Telefon";
            product1.Adet = 20;
            product1.Aciklama = "Son model telefon";
            product1.Fiyat = 1000;

            Product product2 = new Product();
            product2.Adi = "Televizyon";
            product2.Adet = 10;
            product2.Aciklama = "Son model televizyon";
            product2.Fiyat = 15000;

            Product product3 = new Product();
            product3.Adi = "Buzdolabı";
            product3.Adet = 90;
            product3.Aciklama = "Son model buzdolabı";
            product3.Fiyat = 20000;

            Product[] products = new Product[] { product1,product2,product3};
            foreach (Product product in products)
            {
                Console.WriteLine("Ürün Adı="+" "+product.Adi);
                Console.WriteLine("Ürün Adedi="+" "+product.Adet);
                Console.WriteLine("Ürünün Açıklaması="+" "+product.Aciklama);
                Console.WriteLine("Ürün Fiyatı="+" "+ product.Fiyat);
                Console.WriteLine("-------------------------");
            }
            
        }
    }
}
