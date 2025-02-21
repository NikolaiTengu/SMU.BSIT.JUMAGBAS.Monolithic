using Microsoft.AspNetCore.Mvc;
using SMU.BSIT.JUMAGBAS.Monolithic.Models;
using SMU.BSIT.JUMAGBAS.Monolithic.Controllers;
using SMU.BSIT.JUMAGBAS.Monolithic.Services;

namespace SMU.BSIT.JUMAGBAS.Monolithic.Controllers
{
    public class ProductsController 
        : Controller
    {

        private readonly ProductsService _productsService;

        public ProductsController()
        {
            _productsService = new ProductsService();
        }


        public IActionResult Index()
        {
            var viewModel = new ProductsViewModel();

            var products = _productsService.GetProducts();
            viewModel.ProductsList = products;

            ViewBag.ProductId = TempData["ProductId"]?.ToString();
            return View(viewModel);
        }

        public IActionResult SubmitProduct(Product product)
        {
            _productsService.AddProduct(product);
            TempData["ProductId"] = product.Id;
            return RedirectToAction("Index");
        }
        public IActionResult Details([FromQuery] int id)
        {
            var product = _productsService.GetProduct(id);
            return View(product);
        }
    }

}
