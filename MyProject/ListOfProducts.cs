using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyProject
{
    public static class ListOfProducts
    {
        private static ICollection<Product> listOfProducts;
        public static ICollection<Product> getListOfProducts()
        {
            if(listOfProducts == null)
            {
                listOfProducts = new List<Product>();
            }
            return listOfProducts;
        }
        public static void addProduct(Product p)
        {
            // Initialize new list, if it is not already created, and add to it. 
            ListOfProducts.getListOfProducts().Add(p);
        }
        public static void clear()
        {
            ListOfProducts.getListOfProducts().Clear();
        }
    }
}
