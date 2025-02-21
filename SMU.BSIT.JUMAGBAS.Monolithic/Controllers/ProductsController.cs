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
            return View();
        }

        public IActionResult SubmitProduct(Product product)
        {
            _productsService.AddProduct(product);
            return RedirectToAction("Index");
        }

    }

}
