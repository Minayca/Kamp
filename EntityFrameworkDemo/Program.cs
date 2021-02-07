using System;
using System.Linq;

namespace EntityFrameworkDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //GetAll();
            //GetProductsByCategoryId(1);
            GetAllPersonels();
        }

        private static void GetAll()
        {
            NorthwindContext northwindContext = new NorthwindContext();

            foreach (var product in northwindContext.Products)
            {
                Console.WriteLine(product.ProductName);
            }
        }

        private static void GetProductsByCategoryId(int categoryId)
        {
            NorthwindContext northwindContext = new NorthwindContext();

            var result = northwindContext.Products.Where(p => p.CategoryId == categoryId);
            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }
        }

        private static void GetAllPersonels()
        {
            NorthwindContext northwindContext = new NorthwindContext();

            foreach (var personel in northwindContext.Personels)
            {
                Console.WriteLine("{0} / {1} / {2}",personel.Id, personel.Name, personel.Surname);
            }
        }
    }
}
