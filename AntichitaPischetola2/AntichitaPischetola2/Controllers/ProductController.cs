using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AntichitaPischetola2.Services;
using Microsoft.AspNetCore.Mvc;

namespace AntichitaPischetola2.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            IProductsDAO products = new IProductsDAO();
            return View(products.GetAllProducts());
        }

        public IActionResult ShowProduct()
        {
            return View();
        }
    }
}
