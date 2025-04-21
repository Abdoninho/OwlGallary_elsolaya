using System.Diagnostics;
using System.Runtime.CompilerServices;
using Microsoft.AspNetCore.Mvc;
using Owl_Gallery.Data;
using Owl_Gallery.Models;

namespace Owl_Gallery.Controllers
{
    public class IndexController : Controller
    {
        private readonly ILogger<IndexController> _logger;

        public IndexController(ILogger<IndexController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
    }

 

   

    public class ProductsController : Controller
    {

        private GalleryDbContext db;



        private readonly ILogger<ProductsController> _logger;


        public ProductsController(ILogger<ProductsController> logger, GalleryDbContext db)
        {
            _logger = logger;
            this.db = db;
        }

        public IActionResult Products()
        {
            IEnumerable<Product> productList = db.Products.ToList();
            return View(productList);
        }
    }

    public class CheckoutController : Controller
    {
        private readonly ILogger<CheckoutController> _logger;

        public CheckoutController(ILogger<CheckoutController> logger)
        {
            _logger = logger;
        }

        public IActionResult Checkout()
        {
           
                
            return View();
        }
    }

    public class FavoritesController : Controller
    {
        private readonly ILogger<FavoritesController> _logger;

        public FavoritesController(ILogger<FavoritesController> logger)
        {
            _logger = logger;
        }

        public IActionResult Favorites()
        {
            return View();
        }
    }

    public class CartController : Controller
    {
        private readonly ILogger<CartController> _logger;

        public CartController(ILogger<CartController> logger)
        {
            _logger = logger;
        }

        public IActionResult Cart()
        {
            return View();
        }
    }

    public class ErrorController : Controller
    {
        private readonly ILogger<ErrorController> _logger;

        public ErrorController(ILogger<ErrorController> logger)
        {
            _logger = logger;
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}