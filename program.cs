using System;
using System.Collections.Generic;
namespace ProductManagement
{
    internal class Program
    {
        static List<Product> products = new List<Product>();

        static void Main(string[] args)
        {   
            
            int choice;
            do{
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Add ");
                Console.WriteLine("2. Display");
                Console.WriteLine("3. Find");
                Console.WriteLine("4. Exit");
            choice = System.Convert.ToInt32(Console.ReadLine());
            switch(choice)
            {
                case 1:
                Add();
                break;
                case 2:
                Display();
                break;
                case3:
                Find();
                case 4:
                Exit();
                break;
                default:
                Console.WriteLine("Invalid choice.");
                break;
                
            }
            

           
        }while(choice < 4);
        
    }
    static void Add()
    {       int i;
            Console.Write("how many products");
            int x = Convert.ToInt32(Console.ReadLine());
            for(i = 0 ; i< x; i++)
            {
            Product prod = new Product();
            Console.Write("Enter Product Id: ");
            prod.ProdId = System.Convert.ToInt32(Console.ReadLine());
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
            Console.WriteLine("stock" + Product.GetCounter() + "\n");
            products.Add(prod);
            }
            
    }
    static void Display(){
            Console.WriteLine("Displaying Products:");

            foreach (var prod in products)
            {
                Console.WriteLine(prod.Display());
            }

            Console.WriteLine("Total Products: {Product.GetCounter()}");
        }
    static void Find(){
        
        Console.WriteLine("choose product by id");
        int m = Convert.ToInt32(Console.ReadLine());
        foreach (var prod in products)
            {
                if (prod.ProdId == m)
                {
                    Console.WriteLine("Product Found:");
                    Console.WriteLine(prod.Display());
                    return; 
                }
            }

    }
    static void Exit()
        {
            Console.WriteLine("Exiting the program");
        }
    
}}
