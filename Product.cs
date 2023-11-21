using System;
 

namespace Product_Method
{
    public class Product
    {

        
        protected int pid;
        protected string pname;
        protected double pprice;

        // Constructor
        public Product(int pid, string pname, double pprice)
        {
            this.pid = pid;
            this.pname = pname;
            this.pprice = pprice;
        }

        
        public void ShowDetails()
        {
            Console.WriteLine($"Product ID: {pid}");
            Console.WriteLine($"Product Name: {pname}");
            Console.WriteLine($"Product Price: {pprice}");
        }

        // Method to set information
        public void SetInformation(int pid, string pname, double pprice)
        {
            this.pid = pid;
            this.pname = pname;
            this.pprice = pprice;
        }
    }

}

