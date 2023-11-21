using System;
namespace Product_Method
{
    public class HerbalProduct : Product
    {

       
        private string herbsUsed;
        private DateTime mfDate;
        private DateTime expDate;

        // Constructor for HerbalProduct
        public HerbalProduct(int pid, string pname, double pprice, string herbsUsed, DateTime mfDate, DateTime expDate)
            : base(pid, pname, pprice)
        {
            this.herbsUsed = herbsUsed;
            this.mfDate = mfDate;
            this.expDate = expDate;
        }

        // Override methods to add details of HerbalProduct fields
        public new void ShowDetails()
        {
            base.ShowDetails(); // Call the base class method
            Console.WriteLine($"Herbs Used: {herbsUsed}");
            Console.WriteLine($"Manufacture Date: {mfDate.ToShortDateString()}");
            Console.WriteLine($"Expiration Date: {expDate.ToShortDateString()}");
        }

        public new void SetInformation(int pid, string pname, double pprice, string herbsUsed, DateTime mfDate, DateTime expDate)
        {
            base.SetInformation(pid, pname, pprice); // Call the base class method
            this.herbsUsed = herbsUsed;
            this.mfDate = mfDate;
            this.expDate = expDate;
        }
    }

}

