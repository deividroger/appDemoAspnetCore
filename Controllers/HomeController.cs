using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MinhaDemoMVC.Models;

namespace MinhaDemoMVC.Controllers
{
    [Route("")]
    [Route("gestao-clientes")]
    public class HomeController : Controller
    {
        [Route("")]

        [Route("pagina-inicial")]
        [Route("pagina-inicial/{id:int}/{categoria:guid}/{categorias?}")]
        public IActionResult Index(string id, Guid categoria, string categorias)
        {
            return View();
        }

        [Route("sobre")]
        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        [Route("contato")]
        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        [Route("privacidade")]
        [Route("politica-de-privacidade")]
        public IActionResult Privacy(Filme filme)
        {
            if (!ModelState.IsValid) {
                foreach (var item in ModelState.Values.SelectMany(m => m.Errors))
                {
                    Console.WriteLine(item.ErrorMessage);
                }
            }

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        [Route("erro-encontrado")]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
