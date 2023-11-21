using System;
 

namespace Product_Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // Create an object of HerbalProduct class
           HerbalProduct herbalProduct = new HerbalProduct(01, "Herbal Shampoo", 20.99, "Aloe Vera", DateTime.Now, DateTime.Now.AddMonths(8));

           // Display details
           Console.WriteLine("Product Details Before Setting Information:");
           herbalProduct.ShowDetails();

           // Set information
           herbalProduct.SetInformation(02, "Herbal FaceWash", 450.99, "Neem", DateTime.Now, DateTime.Now.AddMonths(12));

           // Display updated details
           Console.WriteLine("\nProduct Details After Setting Information:");
           herbalProduct.ShowDetails();

            Console.ReadKey();

        }
    }
}
