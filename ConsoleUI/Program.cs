using System;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;

namespace ConsoleUI
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //ProductTest();
            //CategoryTest();
        }

        private static void ProductTest()
        {
            var productManager = new ProductManager(new EfProductDal(), new CategoryManager(new EfCategoryDal()));

            //productManager.GetAll().ForEach(p => Console.WriteLine(p.ProductName));
            //productManager.GetAllByCategoryId(2).ForEach(p => Console.WriteLine(p.ProductName));

            var result = productManager.GetProductDetail();
            if (result.Success) result.Data.ForEach(p => Console.WriteLine(p.ProductName + " / " + p.CategoryName));
            else Console.WriteLine(result.Message);
        }

        private static void CategoryTest()
        {
            var categoryManager = new CategoryManager(new EfCategoryDal());
            categoryManager.GetAll().Data.ForEach(c => Console.WriteLine(c.CategoryName));
        }
    }
}