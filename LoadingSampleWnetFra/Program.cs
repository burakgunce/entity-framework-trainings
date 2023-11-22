using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoadingSampleWnetFra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NorthwindEntities db = new NorthwindEntities();
            //EagerLoading(db);

            //LazyLoading(db);

            //ExplicitLoading(db);

            //SqlQueryMethod(db);

        }

        private static void SqlQueryMethod(NorthwindEntities db)
        {
            // sql query
            var orderSqlQuery = db.Orders
                .SqlQuery("select * from Orders where CustomerID = @CustomerID",
                new SqlParameter("@CustomerID", "ALFKI"));
        }

        private static void ExplicitLoading(NorthwindEntities db)
        {
            //Explicit Loading
            var order = db.Orders.Where(o => o.OrderID == 10252).FirstOrDefault();

            db.Entry(order).Reference(x => x.Customers).Load();
            db.Entry(order).Reference(o => o.Employees).Load();

            Console.WriteLine($"{order.OrderID} {order.Customers.CompanyName}" +
                $"{order.Employees.LastName}");
        }

        private static void LazyLoading(NorthwindEntities db)
        {
            //lazy loading
            var customerList = db.Customers.ToList();
            var customer = customerList.Where(x => x.CustomerID == "ALFKI").FirstOrDefault();
            var orderList = customer.Orders.ToList();
        }

        private static void EagerLoading(NorthwindEntities db)
        {
            //Eager Loading-------------------------
            //query syntax
            var categoryList = (from c in db.Categories
                                .Include("Products")
                                where c.CategoryName == "SeaFood"
                                select c).FirstOrDefault();
            var categoryList2 = (from c in db.Categories
                                 .Include("Products")
                                 where c.CategoryName == "SeaFood"
                                 select new
                                 {
                                     CategoryName = c.CategoryName,
                                     ProductCount = c.Products.Count
                                 });
            foreach (var item in categoryList2)
            {
                Console.WriteLine($"{item.CategoryName}{item.ProductCount}");
            }

            //method syntax
            var categoryList3 = db.Categories
                .Include("Products")
                .Where(x => x.CategoryName == "SeaFood")
                .FirstOrDefault();


            //birden fazla ılıskılı datalar ıcın query syntax
            var orderList = (from o in db.Orders
                             .Include("Customers")
                             .Include("Employees")
                             where o.Customers.CustomerID == "ALFKI"
                             select o);
            foreach (var item in orderList)
            {
                Console.WriteLine($"{item.Customers.CompanyName}{item.Employees.FirstName}" +
                    $"{item.Employees.LastName}");
            }
        }
    }
}
