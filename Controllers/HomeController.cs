using Microsoft.AspNetCore.Mvc;
using PracticaInyeccionDependencias.Datos.Interfaces;
using PracticaInyeccionDependencias.Models;
using System.Diagnostics;

namespace PracticaInyeccionDependencias.Controllers
{
    public class HomeController : Controller
    {
        private readonly IServiceCiudades _ciudades;
        private readonly IServiceCiudades _ciudades2;
        private readonly IServiceCiudades _ciudades3;

        public HomeController(IServiceCiudades ciudades, IServiceCiudades ciudades2, IServiceCiudades ciudades3)
        {
            _ciudades = ciudades;
            _ciudades2 = ciudades2;
            _ciudades3 = ciudades3;
        }

        public IActionResult Index()
        {
            List<string> ciudades = _ciudades.GetCiudades();

            ViewBag.InstanciaIdServidor1 = _ciudades.IdServicio;
            ViewBag.InstanciaIdServidor2 = _ciudades2.IdServicio;
            ViewBag.InstanciaIdServidor3 = _ciudades3.IdServicio;

            return View(ciudades);
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