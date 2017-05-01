using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyProject.Products
{
    public class Juice : Product
    {
        private double amountSold;
        private double JUICEPRICE = 12.5;
        public Juice(double amountSold)
        {
            this.amountSold = amountSold;
        }

        public double price()
        {
            return JUICEPRICE * amountSold;
        }

        public string productName()
        {
            return "Juice";
        }
        public double getAmount()
        {
            return amountSold;
        }
    }
}
