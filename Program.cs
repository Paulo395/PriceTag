using Microsoft.Win32;
using PriceTag.Entities;
using System;
using System.Globalization;

namespace PriceTag // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();

            Console.Write("Enter the number of products: ");
            byte num = byte.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                Console.Write("Product #" + i + " data:\n" +
                    "Common, used or imported (c/u/i)? ");
                string type = Console.ReadLine().ToLower();

                products.Add(Registry(type));
            }

            Console.WriteLine("\nPRICE TAGS: ");

            foreach (Product product in products)
            {
                Console.WriteLine(product.PriceTag());
            }
        }

        public static Product Registry(string type)
        {
            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Price: ");
            double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Product product;

            switch (type)
            {
                case "i":
                    Console.Write("Custom free: ");
                    double customFee = double.Parse(Console.ReadLine());
                    product = new ImportedProduct(name,price,customFee);
                    break;
                case "u":
                    Console.Write("Manufacture date: ");
                    DateOnly manuFacture = DateOnly.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    product = new UsedProduct(name,price,manuFacture);
                    break;
                default:
                    product = new Product(name, price);
                    break;
            }

            return product;
        }
    }
}