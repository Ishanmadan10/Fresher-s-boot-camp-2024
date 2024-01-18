using System;
using System.Collections.Generic;

namespace ProductManagement
{
    internal class Program
    {
        static Dictionary<int, Product> products = new Dictionary<int, Product>();

        static void Main(string[] args)
        {   
            int choice;
            do
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Add ");
                Console.WriteLine("2. Display");
                Console.WriteLine("3. Find");
                Console.WriteLine("4. Remove");
                Console.WriteLine("5. Exit");
                choice = System.Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Add();
                        break;
                    case 2:
                        Display();
                        break;
                    case 3:
                        Find();
                        break;
                    case 4:
                        Remove();
                        break;
                    case 5:
                        Exit();
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            } while (choice != 5);
        }

        static void Add()
        {
            string Choice;
            do
            {
                Console.Write("Do you want to add a product? ");
                Choice = Console.ReadLine().ToLower();

                if (Choice == "yes")
                {
                    Product prod = new Product();
                    Console.Write("Enter Product Id: ");
                    int prodId = System.Convert.ToInt32(Console.ReadLine());

                    if (products.ContainsKey(prodId))
                    {
                        Console.WriteLine("Product with the same ID already exists");
                        continue; 
                    }

                    Console.Write("Enter Product Name: ");
                    prod.ProdName = Console.ReadLine();
                    Console.Write("Enter Manufacturing Date (MM/dd/yyyy): ");
                    prod.MfgDate = DateTime.Parse(Console.ReadLine());
                    Console.Write("Enter Warranty: ");
                    prod.Warranty = System.Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter Price: ");
                    prod.Price = System.Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter Tax: ");
                    prod.Tax = System.Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter Discount: ");
                    prod.Discount = System.Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Stock: " + Product.GetCounter() + "\n");

                    products.Add(prodId, prod);
                }
            } while (Choice == "yes");
        }

        static void Display()
        {
            Console.WriteLine("Displaying Products:");

            foreach (var pair in products)
            {
                Console.WriteLine(pair.Value.Display());
            }

            Console.WriteLine("Total Products: " + Product.GetCounter());
        }

        static void Find()
        {
            Console.WriteLine("Enter product id to find:");
            int m = Convert.ToInt32(Console.ReadLine());

            if (products.ContainsKey(m))
            {
                Console.WriteLine("Product Found:");
                Console.WriteLine(products[m].Display());
            }
            else
            {
                Console.WriteLine("Product not found.");
            }
        }
        static void Remove()
        {
            Console.WriteLine("Enter product id to find:");
            int n = Convert.ToInt32(Console.ReadLine());
            if (products.ContainsKey(n))
            {
                products.Remove(n);
                Console.WriteLine("Product removed successfully.");
            }
        }
        static void Exit()
        {
            Console.WriteLine("Exiting the program");
        }
    }
}
