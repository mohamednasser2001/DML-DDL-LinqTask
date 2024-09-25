using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Collections.Generic;
using TaskLinqInBikeStoreDB.Data;
using TaskLinqInBikeStoreDB.Models;

namespace TaskLinqInBikeStoreDB
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //Retrieve all categories from the production.categories table.
            ApplicationDbContext context = new ApplicationDbContext();
            var RetrieveAll = context.Products.ToList();
            foreach (var item in RetrieveAll)
            {
                Console.WriteLine($"id:{item.ProductId} name:{item.ProductName} listPrice: {item.ListPrice}");
            }

            //Retrieve the first product from the production.products table.
            var first=context.Products.FirstOrDefault();
            if(first != null)
            {
                Console.WriteLine($"id:{first.ProductId} name: {first.ProductName}");
            }
            else
            {
                Console.WriteLine("not item");
            }
            //Retrieve a specific product from the production.products table by ID
            var find = context.Products.Find(10);
            Console.WriteLine($"id:{find.ProductId} name:{find.ProductName}");
            ///Retrieve all products from the production.products table with a certain model year.
            var item = context.Products.Where(q => q.ModelYear == 2016).ToList();
            foreach (var item1 in item)
            {
                Console.WriteLine($"id :{item1.ProductId} name: {item1.ProductName} modelyear : {item1.ModelYear}");
            }
            //Retrieve a specific customer from the sales.customers table by ID.
            var RetrieveFind = context.Customers.Find(22);
            Console.WriteLine($"id:{RetrieveFind.CustomerId} name {RetrieveFind.FirstName} email {RetrieveFind.Email}");

            //Retrieve a list of product names and their corresponding brand names.
            var RetrieveList = context.Products.Include(z => z.Brand).ToList();
            foreach (var item1 in RetrieveList)
            {
                Console.WriteLine($"id:{item1.ProductId} name :{item1.ProductName} Brand:{item1.Brand.BrandName}");
            }

            ///Count the number of products in a specific category.
            var count=context.Products.Include(m=>m.Category).count(n=>n.ListPrice).Where(e=>e.CategoryId==90).ToList();

            foreach (var itemmm in RetrieveList)
            {
                Console.WriteLine($"productId{itemmm.ProductId},productName{itemmm.ProductName},categoryId{itemmm.CategoryId}");
            }
            ///Calculate the total list price of all products in a specific category.

            var resualt = context.Products.Include(w=>w.Category).Where(x => x.CategoryId == 2).Sum(s => s.ListPrice);

            foreach (var itemmm in RetrieveList)
            {
                Console.WriteLine($"productId{itemmm.ProductId},productName{itemmm.ProductName},categoryId{itemmm.CategoryId}");
            }

            //Calculate the average list price of products
            var temp = context.Products.Average(e => e.ListPrice);
            Console.WriteLine(temp);
            //Retrieve orders that are completed.
            var completedOrders = context.Orders.Where(r => r.OrderStatus == 2);



        }
    }
}
