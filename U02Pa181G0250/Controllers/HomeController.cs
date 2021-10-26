using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using U02Pa181G0250.Models;

namespace U02Pa181G0250.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            villancicosContext context = new villancicosContext();
            var villa = context.Villancicos.OrderBy(x => x.Nombre);
            return View(villa);
        }

        [Route("Ingles")]
        public IActionResult Ingles()
        {
            villancicosContext context = new villancicosContext();
            var villaing = context.Villancicos
                .Where(x => x.Idioma == "Ingles")
                .OrderBy(x => x.Nombre);
            return View(villaing);
        }

        [Route("Espanol")]
        public IActionResult espanol()
        {
            villancicosContext context = new villancicosContext();
            var villaesp = context.Villancicos
                .Where(x => x.Idioma == "Español")
                .OrderBy(x => x.Nombre);
            return View(villaesp);
        }

        [Route("villancico/{name}")]
        public IActionResult Villancico(string name)
        {
            name = name.Replace("-", " ");
            villancicosContext context = new villancicosContext();
            var villancico = context.Villancicos.FirstOrDefault(X => X.Nombre == name);
            if (villancico == null) { return RedirectToAction("Index"); }
            return View(villancico);
        }
    }
}
