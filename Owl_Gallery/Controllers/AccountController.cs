using System.Diagnostics;
using System.Runtime.CompilerServices;
using Microsoft.AspNetCore.Mvc;
using Owl_Gallery.Data;
using Owl_Gallery.Models;
namespace Owl_Gallery.Controllers
{
    public class AccountController : Controller
    {
        private readonly GalleryDbContext _dbContext;

        private readonly ILogger<AccountController> _logger;

        public AccountController(ILogger<AccountController> logger, GalleryDbContext db)
        {
            _logger = logger;
            _dbContext = db;
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View(new Register());
        }

        [HttpPost]
        public IActionResult Register(Register user)
        {

            if (ModelState.IsValid)
            {
                _dbContext.Registers.Add(user);
                _dbContext.SaveChanges();
                return RedirectToAction("Login", "Account");
            }


            return View(user);
        }



        public IActionResult Login(Customer user)
        {
            if (ModelState.IsValid)
            {
                var registeredUser = _dbContext.Registers.FirstOrDefault(u => u.Email == user.email);

                if (registeredUser != null && registeredUser.Password == user.Password)
                {
                    // Save to Customers table
                    var customer = new Customer
                    {
                        email = user.email,
                        Password = user.Password // Ideally should be hashed
                    };

                    _dbContext.Customers.Add(customer);
                    _dbContext.SaveChanges();

                    return RedirectToAction("Index", "Index"); // Change as needed
                }
                else
                {
                    ModelState.AddModelError("", "Invalid email or password");
                }
            }

            return View(user);
        }


    }
}
