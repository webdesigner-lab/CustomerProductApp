using System;
using System.Collections.Generic;

namespace CustomerShoppingApp
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }
    }

    class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public List<Product> ShoppingList { get; set; }

        public Customer(int id, string name, string email)
        {
            Id = id;
            Name = name;
            Email = email;
            ShoppingList = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            ShoppingList.Add(product);
        }

        public void DisplayCustomerInfo()
        {
            Console.WriteLine("Customer ID: " + Id);
            Console.WriteLine("Customer Name: " + Name);
            Console.WriteLine("Email: " + Email);
            Console.WriteLine("\nShopping List:");
            double total = 0;

            foreach (var product in ShoppingList)
            {
                Console.WriteLine("- " + product.Name + " ($" + product.Price + ")");
                total += product.Price;
            }

            Console.WriteLine("\nTotal Cost: $" + total);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create products
            Product p1 = new Product("Coffee", 10.99);
            Product p2 = new Product("Milk", 3.49);
            Product p3 = new Product("Bread", 4.25);

            // Create customer and add products
            Customer cust1 = new Customer(1, "Alex", "alex@example.com");
            cust1.AddProduct(p1);
            cust1.AddProduct(p2);
            cust1.AddProduct(p3);

            // Display customer info and shopping list
            cust1.DisplayCustomerInfo();

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
