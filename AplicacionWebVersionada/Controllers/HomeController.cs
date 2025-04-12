using System.Diagnostics;
using AplicacionWebVersionada.Models;
using Microsoft.AspNetCore.Mvc;

namespace AplicacionWebVersionada.Controllers
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
        /// <summary>
        /// 
        /// </summary>
        /// <returns>issabela gomez </returns>

        public IActionResult Privacy()
        {
            return View();
        }
        /// <summary>
        /// Accion QUe se encaraga... 
        /// </summary>
        /// <returns></returns>
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
