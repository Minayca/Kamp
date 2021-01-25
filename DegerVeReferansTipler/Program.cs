using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            //Console.WriteLine(sayi1); //30

            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            //Console.WriteLine(sayilar1[0]); //999

            //Değer tipler: int,decimal,float,double,bool
            //Referans tipler: array,class,interface

            Person person1 = new Person();
            Person person2 = new Person();

            person1.FirstName = "Engin";
            person2 = person1;

            person1.FirstName = "Derin";

            //Console.WriteLine(person2.FirstName);

            Customer customer = new Customer();

            customer.FirstName = "Ahmet";
            customer.CreditCardNumber = "1234567890";

            Employee employee = new Employee();

            employee.FirstName = "Veli";

            Person person3 = customer;
            //Console.WriteLine(((Customer)person3).CreditCardNumber);

            PersonManager personManager = new PersonManager();

            personManager.Add(customer);
        }

        class Person
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }

        }

        //Base Class: Person
        class Customer :Person
        {
            public string CreditCardNumber { get; set; }
        }

        class Employee:Person
        {
            public int EmployeeNumber { get; set; }
        }

        class PersonManager
        {
            public void Add(Person person)
            {
                Console.WriteLine(person.FirstName);
            }
        }
    }
}