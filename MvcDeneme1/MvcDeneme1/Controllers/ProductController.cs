using MvcDeneme1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcDeneme1.Controllers
{
    
    public class ProductController : Controller
    {
        ProductRepo repo = new ProductRepo();
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult addProduct()
        {
             
            return View();

        }
       
        
        [HttpPost]
        public ActionResult addProduct(Product addNewProduct)
        {

            repo.addProduct(addNewProduct);
            return RedirectToAction("listProduct");

        }

       [HttpGet]
        public ActionResult listProduct(string q)
        {
            if (q != null)
            {
                return View(repo.search(q));
            }
            else
            {
                return View(repo.getAllProduct());
            }

           
        }

       

    }
}