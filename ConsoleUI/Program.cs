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
            //ProductManager productManager = new ProductManager(new EfProductDal());
            //productManager.GetAll().ForEach(p => Console.WriteLine(p.ProductName));
            //productManager.GetAllByCategoryId(2).ForEach(p => Console.WriteLine(p.ProductName));
            //productManager.GetByUnitPrice(50, 100).ForEach(p => Console.WriteLine(p.ProductName));

            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            categoryManager.GetAll().ForEach(c => Console.WriteLine(c.CategoryName));
        }
    }
}