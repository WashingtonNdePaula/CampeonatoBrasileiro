using CampeonatoBrasileiro.Models;
using CampeonatoBrasileiro.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CampeonatoBrasileiro.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

    }
}