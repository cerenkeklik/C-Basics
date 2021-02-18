using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            // sayi1 = 30


            int[] sayilar = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar = sayilar2;
            sayilar2[0] = 999;
            // sayılar[0] = 999

            //int float double bool - değer tipler
            // array interface class- referans tipler 
            //değer tiplerde değerler atanır, referans tiplerde adres atanır.
        }
    }
}
