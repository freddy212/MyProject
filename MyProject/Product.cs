using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyProject
{
    public interface Product 
    {
        double price();
        string productName();
        double getAmount();
    }
}
