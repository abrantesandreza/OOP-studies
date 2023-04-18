using ProjetoProduto;
using ProjetoProduto.Entities;
using System;
using System.Globalization;
using System.Collections.Generic;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instancia uma lista de Product vazia
            List<Product> productsList = new List<Product>();

            Console.Write("Enter the number of products: ");
            int productQntd = int.Parse(Console.ReadLine());

            for(int i = 1; i <= productQntd; i++)
            {
                Console.WriteLine($"Product #{i} data:");
                Console.Write("Common, used or imported (c/u/i)? ");
                char userResponse = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string productName = Console.ReadLine();

                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                //Caso o produto seja importado
                if (userResponse == 'i')
                {
                    Console.Write("Customs fee: ");
                    double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    //Instancia ImportedProduct e já adiciona à lista productsList
                    productsList.Add(new ImportedProduct(productName, price, customsFee));

                }
                else if (userResponse == 'u')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime manufactureDate = DateTime.Parse(Console.ReadLine());
                    //Instancia UsedProduct e já adiciona à lista productsList
                    productsList.Add(new UsedProduct(productName, price, manufactureDate));
                } 
                else {
                    //Instancia Product e já adiciona à lista productsList
                    productsList.Add(new Product(productName, price));
                }
            }

            Console.WriteLine();
            Console.WriteLine("PRICE TAGS: ");
            //Itera sobre a lista de produtos chamando o metodo PriceTag()
            foreach (Product prod in productsList)
            {
                Console.WriteLine(prod.PriceTag());
            }

        }
    }
}
