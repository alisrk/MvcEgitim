using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcDeneme1.Models 
{
    public class Product 

    {
     
        public int  productID { get; set; }
        
        public  string productName { get; set; }
        public int stok { get; set; }
        public int price { get; set; }
        public string  productImage { get; set; }

    }
}