using System;
using System.Collections.Generic;
using System.Linq;

namespace Shop_LINQ
{
    class Program
    {
        static List<Customer> Customers;
        static List<Customer> CustomersOfOtherShop;
        static List<CustomerOrderProducts> CustomersOrdersProducts;
        static List<Product> Products;
        static void Main(string[] args)
        {
            CustomersProductsOrders_LINQ_Demo();
            //
            Console.ReadKey();
        }

        static void CustomersProductsOrders_LINQ_Demo()
        { 
            Console.WriteLine("CustomersProductsOrders_LINQ_Demo enter");
            SetCustomersProductsOrders_Data();
            //Select enables to return same or new form of the existing data type (projection)
            //ToDo :Select all customers using LINQ
            
            //ToDo :Select all customers names using LINQ
            
            //ToDo : Select all customers names and add Hash field that hold unique Guid using LINQ
            
            //ToDo : Select all customers names using extention method
            
            //the query is executed and the data returns only when the data is requested
            //Deferred execution means that the evaluation of an expression is delayed 
            //until its realized value is actually required. 
            //It greatly improves performance by avoiding unnecessary execution.
            //ToDo : Print all customers

            //ToDo : Selects only distinct customers IDs 

            //possible after implementing IEqualityComparer interface

            //Ordering - arranges the collection in ascending or descending order
            //ToDo : Order products by product name in ascending order using extention method

            //ToDo : Order products by product name in descending order using LINQ

            //Filtering - get items that satisfies a condition
            //ToDo: get customers that has g in their name using extention method

            //ToDo: get customers that has g in their name using LINQ

            // Aggregation 
            //ToDo: summerize the products count for orders that have products

            //ToDo: get the maximum of products count in an order that have products

            //ToDo: get the average of products count in orders that have products

            //ToDo: get the minimum of products count in an order that have products

            //ToDo: get the count of customers orders

            //grouping - group collection by a key 
            //ToDo: group orders by customer id using extention method

            //ToDo: group orders by customer id using LINQ

            // Element Operations - gets one item or default
            //ToDo: get first product

            //ToDo: get last customer

            // Set Operations = Operations on Sets
            //Set Operations - intersection =all elements which are in both A and B ,
            //ToDo: get all customers that are in both shops            

            //Set Operations - Union =all unique elements which are in either A or B (or both)
            //ToDo: get all unique customers that are in both shops            

            //Set Operations - Exept =all elements which are in A but not in B
            //ToDo: get all customers that are not in CustomersOfOtherShop            

            // Quantify Data - Any - checks whether one of the item in the collection satisfies the supplied condition
            //ToDo: check if one of the orders do not have products in it

            // Quantify Data - All - check whether all of items in the collection satisfies the supplied condition
            //ToDo: check if all of the orders do not have products in them

            // Partition data - gets part of the collection , Skip = return items after X items in the collection
            //ToDo: get all the products after the first 2 

            // Partition data - Take = get only X items from the collection
            //ToDo: get 2 products

            //Join operator operates on two collections, inner collection & outer collection. 
            //It returns a new collection that contains elements from both the collections which satisfies specified expression. 
            //It is the same as inner join of SQL            
            //ToDo: get the name of customer , order id, productsCount, total value of each order 

            //ToDo: get the customers id and name that do not have orders

            //
            Console.WriteLine("CustomersProductsOrders_LINQ_Demo exit");
        }
        //
        static void SetCustomersProductsOrders_Data()
        {
            Customers = new List<Customer>();
            CustomersOfOtherShop = new List<Customer>();
            Products = new List<Product>();
            CustomersOrdersProducts = new List<CustomerOrderProducts>();
            //Add customers
            Customers.Add(new Customer() { CustomerID = 1, Email = "Dani" });
            Customers.Add(new Customer() { CustomerID = 2, Email = "Rimon" });
            Customers.Add(new Customer() { CustomerID = 3, Email = "Rona" });
            Customers.Add(new Customer() { CustomerID = 4, Email = "Jeni" });
            Customers.Add(new Customer() { CustomerID = 5, Email = "Abdul" });
            //Add customers of other shop
            CustomersOfOtherShop.Add(new Customer() { CustomerID = 3, Email = "Rona" });
            CustomersOfOtherShop.Add(new Customer() { CustomerID = 5, Email = "Abdul" });
            CustomersOfOtherShop.Add(new Customer() { CustomerID = 9, Email = "Gidon" });
            CustomersOfOtherShop.Add(new Customer() { CustomerID = 21, Email = "Shani" });
            //Add products
            Products.Add(new Product() { ID = 11, Name = "Tahini 0.5KG", Value = 15 });
            Products.Add(new Product() { ID = 12, Name = "Whole bread 0.5KG", Value = 12 });
            Products.Add(new Product() { ID = 13, Name = "Green olives 0.5KG", Value = 25 });
            Products.Add(new Product() { ID = 14, Name = "Orange", Value = 2 });
            Products.Add(new Product() { ID = 15, Name = "Tommato", Value = 1 });
            //Add orders
            CustomersOrdersProducts = new List<CustomerOrderProducts>()
            {
                new CustomerOrderProducts() { OrderID = 21, CustomerID =1},
                new CustomerOrderProducts() { OrderID = 22, CustomerID =3},
                new CustomerOrderProducts() { OrderID = 23 ,CustomerID =4},
                new CustomerOrderProducts() { OrderID = 23 ,CustomerID =4},
                new CustomerOrderProducts() { OrderID = 24, CustomerID =4}
            };
            //Add products to customer orders
            CustomersOrdersProducts.Find(co => co.OrderID == 21).OrderProducts = new List<OrderProduct>()
            {
                new OrderProduct() { OrderID = 21, ProductID = 11, ProductCount = 1 } ,
                new OrderProduct() { OrderID = 21, ProductID = 12, ProductCount = 1 },
                new OrderProduct() { OrderID = 21, ProductID = 13, ProductCount = 1 }
            };
            CustomersOrdersProducts.Find(co => co.OrderID == 22).OrderProducts = new List<OrderProduct>()
            {
                new OrderProduct() { OrderID = 22, ProductID = 14, ProductCount = 2 }
            };
            CustomersOrdersProducts.Find(co => co.OrderID == 23).OrderProducts = new List<OrderProduct>()
            {
                new OrderProduct() { OrderID = 23, ProductID = 14, ProductCount = 5 } ,
                new OrderProduct() { OrderID = 23, ProductID = 15, ProductCount = 5 }
            };
            CustomersOrdersProducts.Find(co => co.OrderID == 24).OrderProducts = new List<OrderProduct>()
            {
                new OrderProduct() { OrderID = 24, ProductID = 11, ProductCount = 5 }
            };
        }
    }
}
