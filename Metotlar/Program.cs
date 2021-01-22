using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Adi = "Elma";
            product1.Fiyati = 15;
            product1.fiyatBirim = "tl";
            product1.Aciklama = "Amasya elması";

            Product product2 = new Product();
            product2.Adi = "Karpuz";
            product2.Fiyati = 80;
            product2.fiyatBirim = "tl";
            product2.Aciklama = "Diyabakır karpuzu";

            Product[] products = new Product[] {product1,product2 };

            //type safe -- tip güvenli
            //ilk product yerine var da olur
            foreach (Product product in products)
            {
                Console.WriteLine(product.Adi);
                Console.WriteLine(product.Fiyati + product.fiyatBirim);
                Console.WriteLine(product.Aciklama);
                Console.WriteLine("------------");

            }

            Console.WriteLine("---------Metotlar----------");

            //instance - örnek
            //encapsulation
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(product1);
            sepetManager.Ekle(product2);

            sepetManager.Ekle2("Armut", "Yeşil armut", 12, "tl", 10);
            sepetManager.Ekle2("Elma", "Yeşil elma", 12, "tl", 9);
            sepetManager.Ekle2("Karpuz", "Diyarbakır karpuzu", 12, "tl", 8);

        }
    }
}



//dont repeat yourself - DRY - Clean Code - Best Practice