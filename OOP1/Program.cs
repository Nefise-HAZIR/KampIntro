using System;

namespace OOP1 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.ProductName = "masa";
            product1.CategoryId = 2;
            product1.UnitPrice = 400;
            product1.UnitsInStock = 4;

            Product product2 = new Product
            {
                Id = 2, CategoryId = 3,UnitPrice=5,UnitsInStock=76,ProductName="kalem"
            };
            ProductManager productManager=new ProductManager();
            productManager.Add(product1);
        }
    }
}