using CampeonatoBrasileiro.Models;
using CampeonatoBrasileiro.Services;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using static System.Net.Mime.MediaTypeNames;

namespace CampeonatoBrasileiro.Controllers
{
    public class ClassificacaoController : Controller
    {
        public ClassificacaoController()
        {
        }

        // GET: Classificacao
        public ActionResult Index()
        {
            var tabela = Campeonato.GetTabela();
            return View(tabela);
        }
    }
}