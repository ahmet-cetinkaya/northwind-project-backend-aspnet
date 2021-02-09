using System;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;

namespace ConsoleUI
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            ProductTest();
            //CategoryTest();
        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());

            //productManager.GetAll().ForEach(p => Console.WriteLine(p.ProductName));
            //productManager.GetAllByCategoryId(2).ForEach(p => Console.WriteLine(p.ProductName));

            productManager.GetProductDetail().ForEach(p => Console.WriteLine(p.ProductName + " / " + p.CategoryName));
        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            categoryManager.GetAll().ForEach(c => Console.WriteLine(c.CategoryName));
        }
    }
}