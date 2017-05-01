using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyProject.Products
{
    public class Bread : Product
    {
        private double amountSold;
        private double BREADPRICE = 5;
        public Bread(double amountSold)
        {
            this.amountSold = amountSold;
        }
        public double price()
        {
            return BREADPRICE * amountSold;
        }

        public string productName()
        {
            return "Bread";
        }

        public double getAmount()
        {
            return amountSold;
        }
    }
}
