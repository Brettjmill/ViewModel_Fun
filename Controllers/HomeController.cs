using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ViewModel_Fun.Models;

namespace ViewModel_Fun.Controllers
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
            string blurb = "Here is a series of words and phrases that will eventually populate another web page.";
            return View("Index", blurb);
        }

        public IActionResult Numbers()
        {
            int[] nums = new int[]
            {
                1,
                2,
                3,
                10,
                43,
                5
            };
            return View("Numbers", nums);
        }

        public IActionResult AllUsers()
        {
            List<User> UserList = new List<User>
            {
                new User("Steve", "Stevenson"),
                new User("Sarah"),
                new User("Jerry"),
                new User("Rene", "Ricky"),
                new User("Barbarah")
            };
            return View("AllUsers", UserList);
        }

        public IActionResult SingleUser()
        {
            User person = new User("Steve", "Stevenson");
            return View("SingleUser", person);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
