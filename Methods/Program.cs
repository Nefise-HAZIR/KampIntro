
using System;

namespace Methods
{
     class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Adi = "Elma";
            product1.Aciklama = "arjantin";
            product1.Fiyat = 10;

            Product product2 = new Product();
            product2.Adi = "Karpuz";
            product2.Aciklama = "ADANA";
            product2.Fiyat = 20;

            Product[] products = new Product[] { product1, product2 };
            foreach (Product product in products)
            {
                Console.WriteLine(product.Adi);  //Console.WriteLine(product.Adi,product.Aciklama,product.Fiyat) OLMUYOR
                Console.WriteLine(product.Aciklama);
                Console.WriteLine(product.Fiyat);
            }
            
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(product1);
            Console.ReadLine();
        }
    }
}