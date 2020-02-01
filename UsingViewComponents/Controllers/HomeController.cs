using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UsingViewComponents.Models;
namespace UsingViewComponents.Controllers
{
    public class HomeController:Controller
    {
        private IProductRepository repository;
        public HomeController(IProductRepository productRepository)
        {
            repository = productRepository;
        }
        public ViewResult Index() => View(repository.Products);
        public ViewResult Create() => View();
        [HttpPost]
        public IActionResult Create(Product product)
        {
            repository.AddProduct(product);
            return RedirectToAction("Index");
        }
    }
}
