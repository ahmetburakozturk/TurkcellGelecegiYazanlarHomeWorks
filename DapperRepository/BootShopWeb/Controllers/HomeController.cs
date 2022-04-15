using BootShop.Businness;
using BootShopWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Diagnostics;
using System.Linq;


namespace BootShopWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IProductService productService;
        private readonly ICategoryService _categoryService;

        public HomeController(ILogger<HomeController> logger, IProductService productService, ICategoryService categoryService)
        {
            _logger = logger;
            this.productService = productService;
            _categoryService = categoryService;
        }

        public IActionResult Index(int page = 1, string? catName = null)
        {
            var categories = _categoryService.GetCategories().Where(x => x.Name == catName);
            var category = categories.LastOrDefault();
            var products = catName != null
                ? productService.GetProducts().Where(p => p.CategoryId == category.ID).ToList()
                : productService.GetProducts();
            var productsPerPage = 4;
            var paginatedProducts = products.OrderBy(x => x.ID)
                                                    .Skip((page - 1) * productsPerPage)
                                                    .Take(productsPerPage);
            ViewBag.CurrentPage = page;
            ViewBag.CurrentCategory = catName;
            ViewBag.TotalPages = Math.Ceiling((decimal)products.Count / productsPerPage);
            return View(paginatedProducts);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}