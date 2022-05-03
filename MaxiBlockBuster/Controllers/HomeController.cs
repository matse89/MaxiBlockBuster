using MaxiBlockBuster.BLL;
using MaxiBlockBuster.BLL.Services;
using MaxiBlockBuster.Model;
using MaxiBlockBuster.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Diagnostics;

namespace MaxiBlockBuster.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IMain _main;



        public HomeController(ILogger<HomeController> logger, IMain main)
        {
            _logger = logger;
            _main = main;
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

        public IActionResult Peliculas()
        {
            return Json(_main.Peliculas.GetPeliculas());
        }
        [HttpPost]
        public IActionResult NuevaPelicula([FromBody] string nombre)
        {
            return Json(_main.Peliculas.AgregarPelicula(nombre));
        }
    }
}