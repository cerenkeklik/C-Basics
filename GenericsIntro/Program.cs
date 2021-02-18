using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> names = new MyList<string>();
            names.Add("Ceren");
            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            Console.WriteLine(myDictionary.Length());
            myDictionary.Add(3, "Ceren");
            Console.WriteLine(myDictionary.Length());
        }
    }
}
