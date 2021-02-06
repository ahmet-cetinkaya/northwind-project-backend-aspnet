using System;
using Business.Concrete;
using DataAccess.Concrete.InMemory;

namespace ConsoleUI
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new InMemoryProductDal());
            productManager.GetAll().ForEach(p => Console.WriteLine(p.ProductName));
        }
    }
}