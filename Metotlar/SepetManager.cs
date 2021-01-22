using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        //naming convention
        public void Ekle(Product product)
        {
            Console.WriteLine("Tebrikler. Sepete Eklendi : " + product.Adi +" "+ product.Aciklama+" "+ product.Fiyati + product.fiyatBirim);
            
        }
        //Yukarıdaki kullanım daha doğru. Alttaki kullanımda yeni girdi olduğu zaman patlıyor.
        public void Ekle2(string productAdi, string aciklama, double fiyat, string fiyatBirim, int stokAdedi)
        {
            Console.WriteLine("Tebrikler. Sepete Eklendi : " + productAdi +" "+ aciklama +" "+ fiyat + fiyatBirim);
        }
    }
}
