using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment4
{
    class Program
    {
        static void Main(string[] args)
        {

            #region INSTANTIATING CUSTOMERS
            Product p1 = new Product { Name = "Milk", Price = 8 };
            Product p2 = new Product { Name = "Butter", Price = 20 };
            Product p3 = new Product { Name = "Bread", Price = 18 };

            Order order1 = new Order { Quantity = 2, Product = p1 };
            Order order2 = new Order { Quantity = 2, Product = p2 };
            Order order3 = new Order { Quantity = 2, Product = p3 };
            Customer customer1 = new Customer { Name = "Kim Foged", City = "Beder", Orders = new Order[] { order1, order2, order3 } };

            Product p4 = new Product { Name = "Milk", Price = 8 };
            Product p5 = new Product { Name = "Butter", Price = 20 };
            Product p6 = new Product { Name = "Bread", Price = 18 };
            Product p7 = new Product { Name = "Cacao", Price = 30 };

            Order order4 = new Order { Quantity = 2, Product = p4 };
            Order order5 = new Order { Quantity = 2, Product = p5 };
            Order order6 = new Order { Quantity = 2, Product = p6 };
            Order order7 = new Order { Quantity = 2, Product = p7 };
            Customer customer2 = new Customer { Name = "Ib Havn", City = "Horsens", Orders = new Order[] { order4, order5, order6, order7 } };

            Product p8 = new Product { Name = "Juice", Price = 12 };

            Order order8 = new Order { Quantity = 2, Product = p8 };
            Customer customer3 = new Customer { Name = "Rasmus Bjerne", City = "Horsens", Orders = new Order[] { order8 } };

            #endregion

            List<Customer> customers = new List<Customer>() { customer1, customer2, customer3 };


            #region SELECTING ALL CUSTOMER NAME AND CITY
            Console.WriteLine("--------------SELECTING ALL CUSTOMER NAME AND CITY!!------------");
            var allCustomer = customers.Select(i => new { i.Name, i.City }).ToList();

            foreach (var item in allCustomer)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("");
            #endregion


            #region SELECTING ALL CUSTOMER FROM HORSENS
            Console.WriteLine("--------------SELECTING ALL CUSTOMER FROM HORSENS!!------------");
            var fromHorsens = from c in customers
                              where c.City == "Horsens"
                              select c.Name;

            foreach (var ite in fromHorsens)
            {
                Console.WriteLine(ite);
            }
            Console.WriteLine("");
            #endregion


            #region SELECTING ALL NUMBER OF ORDERS FROM IB HAVN
            Console.WriteLine("--------------SELECTING ALL NUMBER OF ORDERS FROM IB HAVN!!------------");
            var orderFromIb = from ib in customers
                              where ib.Name == "Ib Havn"
                              select ib.Orders.Count();

            foreach (var it in orderFromIb)
            {
                Console.WriteLine(it);
            }
            Console.WriteLine("");
            #endregion


            #region SELECTING ALL THE CUSTOMERS BUYING MILK
            Console.WriteLine("--------------SELECTING ALL CUSTOMER BUYING MILK!!------------");
            IEnumerable<List<char>> buyingMilk;
            for (int i = 0; i < customers.Count; i++)
            {
                buyingMilk = from m in customers
                                 where m.Orders[i].Product.Name == "Milk"
                                 select m.Name.ToList();
            }

            //foreach (var item in buyingMilk)
            {
                //Console.WriteLine(item);
            }
            Console.WriteLine("");
            #endregion

            Console.ReadKey();
        }
    }
}
