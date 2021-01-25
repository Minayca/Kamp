using System;

namespace DictionaryProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            MyDictionary<int, string> kelimeler = new MyDictionary<int, string>();

            kelimeler.Add(1, "ağaç");
            kelimeler.Add(2, "toprak");
            kelimeler.Add(3, "çiçek");
            kelimeler.Add(4, "dere");

            kelimeler.Show();

            Console.WriteLine(kelimeler.values[2]); 
            //Bu şekilde yazdırabilmek için keys ve values dizilerini public tanımlamalıyız.
        }
    }
}
