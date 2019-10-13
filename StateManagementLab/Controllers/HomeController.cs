using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using StateManagementLab.Models;

namespace StateManagementLab.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
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
        public IActionResult Registration()
        {
            return View();
        }
        // The bottom Action is an Overload
        public IActionResult Registration(User u)
        {
            List<User> Users = new List<User>();
            User Pika = new User("Pikachu", "thundershock");
            User Squirt = new User("Squirtle", "watergun");
            User Bulb = new User("Bulb", "vinewhip");
            User Charm = new User("Charmander", "flamethrower");
            Users.Add(Charm);
            Users.Add(Bulb);
            Users.Add(Squirt);
            Users.Add(Pika);
            return View();
        }

    }
}
