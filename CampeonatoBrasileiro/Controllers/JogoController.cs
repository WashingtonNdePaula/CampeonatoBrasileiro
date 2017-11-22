using CampeonatoBrasileiro.Models;
using CampeonatoBrasileiro.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CampeonatoBrasileiro.Controllers
{
    public class JogoController : Controller
    {
        // GET: Jogo
        public ActionResult Index(int gameId)
        {
            BoxScore jogo = Campeonato.GetBoxScore(gameId);
            return View(jogo);
        }
    }
}