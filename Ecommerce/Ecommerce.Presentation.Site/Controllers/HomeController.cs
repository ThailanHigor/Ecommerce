using AutoMapper;
using Ecommerce.Application.Interfaces;
using Ecommerce.Domain.Entities;
using Ecommerce.Presentation.Site.Models;
using Ecommerce.Presentation.Site.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Diagnostics;

namespace Ecommerce.Presentation.Site.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProdutoAppService _produtoApp;
        private readonly IMapper _mapper;

        public HomeController(IProdutoAppService produtoApp, IMapper mapper)
        {
            _produtoApp = produtoApp;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            var products = _mapper.Map<IEnumerable<ProdutoViewModel>>(_produtoApp.GetAll());
            return View(products);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(ProdutoViewModel model)
        {
            var product = _mapper.Map<Produto>(model);
            _produtoApp.Add(product);

            return Redirect("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
