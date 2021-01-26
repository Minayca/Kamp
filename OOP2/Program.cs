using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Engin Demiroğ
            Individual customer1 = new Individual();
            customer1.Id = 1;
            customer1.CustomerNo = "12345";
            customer1.Name = "Engin";
            customer1.Surname = "Demiroğ";
            customer1.TcNo = "12345678910";

            //Kodlama.io
            Coorporate customer2 = new Coorporate();
            customer2.Id = 2;
            customer2.CustomerNo = "54321";
            customer2.CompanyName = "Kodlama.io";
            customer2.TaxNo = "1234567890";

            Customer customer3 = new Individual();
            Customer customer4 = new Coorporate();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);

            //Gerçek Müşteri -Tüzel Müşteri
            //SOLID

        }
    }
}
