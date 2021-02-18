using System;

namespace CampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            kurs kurs1 = new kurs();
            kurs1.KursAdi = "c#";
            kurs1.Egitmen = "Engin demiroğ";
            kurs1.IzlenmeOrani = 60;

            kurs kurs2 = new kurs();
            kurs2.KursAdi = "java";
            kurs2.Egitmen = "kerem";
            kurs2.IzlenmeOrani = 64;

            kurs kurs3 = new kurs();
            kurs3.KursAdi = "python";
            kurs3.Egitmen = "berkay";
            kurs3.IzlenmeOrani = 30;

            kurs[] kurslar = new kurs[] { kurs1, kurs2, kurs3 };

            foreach (kurs kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi);
                Console.WriteLine(kurs.Egitmen);
                Console.WriteLine(kurs.IzlenmeOrani);
            }
        }
    }
    class kurs
    {
        public string KursAdi { get; set; }

        public string Egitmen { get; set; }

        public int IzlenmeOrani { get; set; }
    }
}
