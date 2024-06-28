using Assignment02.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Assignment02.Controllers
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
            Inventory inventory = new Inventory();
            Dictionary<string,int> equipments = inventory.Equipments;
            List<Member> members = inventory.Members;

            var inventoryModel = new Inventory
            {
                Equipments = equipments,
                Members = members

            };

            return View(inventoryModel);
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
