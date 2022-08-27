using System;

namespace Odev2_6
{
    class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string Category { get; set; }
    }

    class Program

    {

        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.ProductName = "samsong";
            product1.Category = "phone";

            Product product2 = new Product();
            product2.Id = 2;
            product2.ProductName = "kaan";
            product2.Category = "essek";

            Product product3 = new Product();
            product3.Id = 42;
            product3.ProductName = "neco";
            product3.Category = "dana";

            Product[] products = new Product[] { product1, product2, product3 };

            /* foreach (var product in products)
             {
                 Console.WriteLine(product.Id);
                 Console.WriteLine(product.ProductName);
                 Console.WriteLine(product.Category);
                 Console.WriteLine( );


             }*/

           /* for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine(products[i].Id);
            }*/

            int i = 0;
            while (i < products.Length)
            {
                Console.WriteLine(products[i].ProductName);
                i++;
            }

            Console.ReadLine();

        }

    }

}