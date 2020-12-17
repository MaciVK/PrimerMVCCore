using Microsoft.AspNetCore.Mvc;
using PrimerMVCCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrimerMVCCore.Controllers
{
    public class InformacionController : Controller
    {
        public IActionResult VistaPost()
        {
            return View();
        }
        [HttpPost]
        public IActionResult VistaPost(string cajanombre, string cajaedad)
        {
            ViewBag.Nombre = cajanombre;
            ViewBag.Edad = cajaedad;
            return View();
        }
        public IActionResult VistaDatos(string aplicacion, int version)
        {
            ViewBag.Aplicacion = aplicacion;
            ViewBag.Version = version;
            return View();
        }
        public IActionResult Inicio()
        {
            ViewBag.Nombre = "Alumno";
            ViewBag.Edad = 19;
            Persona person = new Persona();
            person.Nombre = "Modelo";
            person.Edad = 111;
            person.Genero = "Dunno";
            return View(person);
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
