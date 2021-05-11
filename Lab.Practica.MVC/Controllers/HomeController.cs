using Lab.Practica.MVC.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;


namespace Lab.Practica.MVC.Controllers
{
    public class HomeController : Controller
    {
        public async Task<ActionResult> Index()
        {
            PublicApiView cotizacion = new PublicApiView();
            var httpClient = new HttpClient();
            var json = await httpClient.GetStringAsync("https://api-dolar-argentina.herokuapp.com/api/dolaroficial");

            cotizacion = JsonConvert.DeserializeObject<PublicApiView>(json);
            
            return View(cotizacion);
        }      
    }
}