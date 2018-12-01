using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstCliMvcProject.Models
{
    public class ProductViewModel
    {
        public Product product { get; set; }
        public List<SelectListItem> brands { get; set; }
    }
}
