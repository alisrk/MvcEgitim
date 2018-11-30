using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcDeneme1.Models
{
    public class ProductRepo
    {
        private static List<Product> listProducts;

        public ProductRepo()
        {
            if (listProducts == null)
            {
                listProducts = new List<Product>();
            }
            
        }
       
        public void addProduct(Product newProduct)
        {
            listProducts.Add(newProduct);
            
        }
        public List<Product> getAllProduct()
        {
            return listProducts;
        }
        public List<Product> search(string q)
            
        {
            List<Product> searchProduct = new List<Product>();
            foreach(Product products in listProducts)
            {
                bool result = products.productName.Contains(q);
                if (result)
                {
                    searchProduct.Add(products);
                }


            }
            return searchProduct;
        }
    }
}