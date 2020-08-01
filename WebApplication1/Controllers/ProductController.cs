using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ProductController : Controller
    {
		MyContext context;
		public ProductController(MyContext ctxt)
		{
			context = ctxt;
		}

        public IActionResult Index()
        {
			var products =	context.Product.ToList();

            return View(products);
        }


    }
}