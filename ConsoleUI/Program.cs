using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductTest();
            //IoC
            // CategoryTest();


            Console.ReadLine();
        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            foreach (var cat in categoryManager.GetAll())
            {
                Console.WriteLine(cat.CategoryName);
            }
            Console.ReadLine();
        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            Console.WriteLine("####################");

            foreach (var p in productManager.GetProductDetails())
            {
                Console.WriteLine(p.ProductName+"/"+p.CategoryName);
            }
            Console.ReadLine();
        }
    }
}
