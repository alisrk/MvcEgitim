using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstCliMvcProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FirstCliMvcProject.Controllers
{
    public class ProductController : Controller
    {  
        public IActionResult Index()
        {
            return View();

        }


        [HttpGet]
        public IActionResult AddProduct()
        {
            List<SelectListItem> brands = new List<SelectListItem>()
            {
                new SelectListItem("reno","renault"),
                new SelectListItem("merc","merco")

            };

            ProductViewModel model = new ProductViewModel();
            model.brands = brands;

            return View(model);
        }

        [HttpPost]
     public IActionResult AddProduct(ProductViewModel model1)
        {

            string marka = model1.product.marka;


            return RedirectToAction("Index");
        }
        
    }
}