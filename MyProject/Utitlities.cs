using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyProject
{
    public static class Utitlities
    {
        // If some other requirement arose to have a different html output showing the products, 
        //i would refractor this into an interface, with the responsibility of creating the html. 
        //I want to create the html severside, because otherwise someone could overwrite the value
        //I want to have a string in my database, instead of a product, as i find this easier to manage. 
        // This is possible, because the fields of the products are constants, that don't change
        public static string getProductsInHtml()
        {
            string result = "";
            foreach (var product in ListOfProducts.getListOfProducts())
            {
                result += @"<h3> " + product.productName() + " : You have ordered " + product.getAmount() + " with a cost of: " + product.price() + @" </ h3>";
            }
            return result;
        }
        public static double getTotalPrice()
        {
            double total = 0;
            foreach(var product in ListOfProducts.getListOfProducts())
            {
                total += product.price();
            }
            return total;
        }
    }
}
