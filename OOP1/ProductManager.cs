using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
        public void Add(Product product) //Product türünde product.
        {
            Console.WriteLine(product.ProductName + " eklendi.");
        }

        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " güncellendi.");
        }
       
        
        
        
        
        
        //void --> Void metotları, emir kipinde git ekle, git güncelle.
        //İşlem sonucunda ekstra bir bilgiye ihtiyacımız yoksa void tanımlıyoruz

        //public int Topla(int sayi1, int sayi2)
        //{
        //    return sayi1 + sayi2;
        //}

        //public void Topla2(int sayi1, int sayi2)
        //{
        //    Console.WriteLine(sayi1 + sayi2);

        //}
        ////Topla2 işini yapıyor. sayi1 ile sayi2 yi topluyor ve onu ekrana yazdırıyor.
        ////
    }
}
