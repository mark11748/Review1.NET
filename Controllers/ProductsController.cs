using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Review1_NET.Models;
using Microsoft.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Review1_NET.Controllers
{
    public class ProductsController : Controller
    {
        private MyContext db = new MyContext();
        // GET: /<controller>/
        public IActionResult Index()
        {
            List<Product> myProducts = db.Products.ToList();
            return View(myProducts);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Product product)
        {
            db.Products.Add(product);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Details(int id)
        {
            Product model = db.Products.FirstOrDefault(product=>product.ProductId==id);
            return View(model);
        }
    }
}
