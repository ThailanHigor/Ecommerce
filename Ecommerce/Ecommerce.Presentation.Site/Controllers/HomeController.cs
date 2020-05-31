using Ecommerce.Application.Interfaces;
using Ecommerce.Domain.Entities;
using Ecommerce.Presentation.Site.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Ecommerce.Presentation.Site.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProdutoAppService _produtoApp;

        public HomeController(IProdutoAppService produtoApp)
        {
            _produtoApp = produtoApp;
        }

        public IActionResult Index()
        {
            var products = _produtoApp.GetAll();
            return View(products);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Produto model)
        {
            _produtoApp.Add(model);
            return Redirect("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
