using System;
using System.Collections.Generic;
using System.Text;

namespace methods
{
    class SepetManager
    {
        //naming convention
        public void Ekle(Product product)
        {
            Console.WriteLine("Sepete eklendi : " + product.Adi);

        }

        //yanlış kullanım
        public void Ekle2(string urunAdi, string aciklama, double fiyat)
        {
            Console.WriteLine("Sepete eklendi : " + urunAdi);
        }

    }
}
