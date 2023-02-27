using KatmaniMimari.Dal;
using KatmanliMimari.UI.Models;
using KatmanliMimari.Uow;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace KatmanliMimari.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly IUnitofWork _uw;
        public HomeController(ILogger<HomeController> logger, IUnitofWork uw)
        {
            _logger = logger;
            _uw = uw;   
        }

        public IActionResult Index()
        {
            var ls =  _uw._personelRep.List();
            return View(ls);
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