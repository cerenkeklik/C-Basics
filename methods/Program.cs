using System;

namespace methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Product urun1 = new Product();
            urun1.Adi = "elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";

            Product urun2 = new Product();
            urun2.Adi = "çilek";
            urun2.Fiyati = 10;
            urun2.Aciklama = "organik çilek";

            Product[] urunler = new Product[] {urun1,urun2 };

            foreach (Product product in urunler)
            {
                Console.WriteLine(product.Adi);
                Console.WriteLine(product.Fiyati);
                Console.WriteLine(product.Aciklama);
                Console.WriteLine("------------------------");
            }

            Console.WriteLine("------------Methods-------------");
            //instance- örnek
            //encapsulation- yeni bir property eklediğin zaman direkt productdan eklersin. Program patlamaz. Mesela Stok adedi.
            //encapsulationda sen aslında ayrı ayrı yazacağın ve düzensiz olacak yapıyı bir düzenin, kapsülün içine sokuyorsun.
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            //yanlış kullanım çünkü yeni bir property eklemek istediğinde sıkıntı çıkarır.
            sepetManager.Ekle2("muz", "yerli muz", 10);

        }
    }
}
