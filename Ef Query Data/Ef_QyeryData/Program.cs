
using Ef_QyeryData.Data;
using Microsoft.EntityFrameworkCore;

namespace Ef_QyeryData
   
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BikeStoresContext context = new BikeStoresContext();
            //Retrieve all categories from the production.categories table.
            var categories = context.Categories.ToList();
            foreach (var item in categories)
            {
                Console.WriteLine(item.CategoryName);
            }
            //Retrieve the first product from the production.products table
            try
            {

                var firstProduct = context.Products.FirstOrDefault();
                Console.WriteLine(firstProduct.ProductName);

            }
            catch { Console.WriteLine("there is error"); }
            //Retrieve a specific product from the production.products table by ID.
            try
            {
                var specialProduct = context.Products.Find(7);
                Console.WriteLine(specialProduct.ProductName);
            }
            catch { Console.WriteLine("There is Erorr"); }

            //Retrieve all products from the production.products table with a certain model year.
            try
            {
                var product = context.Products.Where(e => e.ModelYear == 2018).FirstOrDefault();
                Console.WriteLine(product.ProductName);

            }
            catch { Console.WriteLine("There is Erorr"); }

            //Retrieve a specific customer from the sales.customers table by ID.
            try
            {
                var specialCustomar = context.Customers.Find(7);
                Console.WriteLine(specialCustomar.FirstName);

            }
            catch { Console.WriteLine("There is Erorr"); }

            //Retrieve a list of product names and their corresponding brand names.
            try
            {
                var items = context.Products.Select(e => new { e.ProductName, e.Brand.BrandName }).ToList();
                foreach (var item in items)
                {
                    Console.WriteLine($"{item.ProductName}==>{item.BrandName}");
                }
            }
            catch
            {
                Console.WriteLine("There is Erorr");

            }

            //Count the number of products in a specific category.
            try
            {
                var products = context.Products.Include(e => e.Category)
                    .Where(e => e.Category.CategoryId == 6)
                    .Select(e => e.ProductName).Count();


                Console.WriteLine(products);

            }
            catch
            {
                Console.WriteLine("There is Erorr");

            }

            //Calculate the total list price of all products in a specific category.
            //Calculate the average list price of products.
            try
            {
                var Total = context.Products.Include(e => e.Category)
                    .Where(e => e.Category.CategoryId == 6)
                    .Select(e => e.ListPrice).Sum();
                var avg = context.Products.Include(e => e.Category)
                    .Where(e => e.Category.CategoryId == 6)
                    .Select(e => e.ListPrice).Average();

                Console.WriteLine($"Total is :{Total}");
                Console.WriteLine($"Avarage is : {avg}");

            }
            catch
            {
                Console.WriteLine("There is Erorr");

            }

            //Retrieve orders that are completed.
            try
            {
                var completed = context.Orders
                    .Where(e => e.OrderStatus == 4)
                    .Select(e => new { e.Customer.FirstName, e.Staff.LastName, e.ShippedDate })
                    .ToList();
                foreach (var item in completed)
                {
                    Console.WriteLine($"{item.FirstName}==>{item.LastName}==>{item.ShippedDate}");
                }
            }
            catch
            {

                Console.WriteLine("There is Erorr");
            }
        }
    }
}
