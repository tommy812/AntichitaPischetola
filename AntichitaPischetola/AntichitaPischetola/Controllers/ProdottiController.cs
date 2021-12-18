using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AntichitaPischetola.Controllers
{
    public class ProdottiController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CreateProduct()
        {
            return View();
        }
        public IActionResult EditProduct()
        {
            return View();
        }

    }
}
