using LanguageFeatures.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;


namespace LanguageFeatures.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            Product[] products = Product.GetProducts(); 
            return View(new string[] { products[0].Name  });
        }
    }
}