using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Lab.Practica.MVC.Controllers
{
    public class HomeController : Controller
    {
        public async Task<ActionResult> Index()
        {
            return View();
        }

            cotizacion = JsonConvert.DeserializeObject<PublicApiView>(json);
            
            return View(cotizacion);
        }      
    }
}