using System;

namespace Delegates
{
    class Program
    {
        public delegate void MyDelegate(); //Elçi görevi görür.
        public delegate void MyDelegate2(string text);
        public delegate int MyDelegate3(int number1, int number2);
        static void Main(string[] args)
        {
            Matematik matematik = new Matematik();
            CustomerManager customerManager = new CustomerManager();
            //customerManager.SendMessage();
            //customerManager.ShowAlert();

            MyDelegate myDelegate = customerManager.SendMessage;
            MyDelegate2 myDelegate2 = customerManager.SendMessage2;
            MyDelegate3 myDelegate3 = matematik.Topla;

            myDelegate3 += matematik.Carp; 
            //Delegate'lerde eğer bir return type varsa en sonuncuyu kabul edip döndürür.
            var sonuc = myDelegate3(2, 3);
            Console.WriteLine(sonuc);

            myDelegate2 += customerManager.ShowAlert2;
            myDelegate2("Hello"); //aynı değişkeni göndermemiz gerekiyor.

            myDelegate += customerManager.ShowAlert;
            myDelegate -= customerManager.SendMessage;
            myDelegate();

            Func<int, int, int> add = matematik.Topla;
            Console.WriteLine(add(3,5));

            Func<int> getRandomNumber = delegate ()
            {
                Random random = new Random();
                return random.Next(1, 100);
            };

            Func<int> getRandomNumber2 = () => new Random().Next(1, 100);

            Console.WriteLine(getRandomNumber());
            Console.WriteLine(getRandomNumber2());
        }
    }

    class CustomerManager
    {
        public void SendMessage()
        {
            Console.WriteLine("Hello!");
        }

        public void ShowAlert()
        {
            Console.WriteLine("Be careful!");
        }

        public void SendMessage2(string message)
        {
            Console.WriteLine(message);
        }

        public void ShowAlert2(string alert)
        {
            Console.WriteLine(alert);
        }
    }

    class Matematik
    {
        public int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }

        public int Carp(int sayi1, int sayi2)
        {
            return sayi1 * sayi2;
        }

    }
}
