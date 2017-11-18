using CampeonatoBrasileiro.Models;
using CampeonatoBrasileiro.Services;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace CampeonatoBrasileiro.Controllers
{
    public class ClassificacaoController : Controller
    {
        private Competition competition;
        public ClassificacaoController()
        {
            competition = Campeonato.GetCompetitiion();
        }

        // GET: Classificacao
        public ActionResult Index()
        {
            var tabela = new List<Classificacao>();
            foreach (var time in competition.Teams)
            {
                var classificacao = Campeonato.GetJogos(competition, time.TeamId);
                classificacao.Time = time.Name;
                tabela.Add(classificacao);
            }
            var index = tabela.OrderByDescending(t => t.Ponto)
                .ThenByDescending(t=> t.Vitoria)
                .ThenByDescending(t=> t.SaldoGol)
                .ThenByDescending(t=> t.GolPro)
                .ToList();
            return View(index);
        }
    }
}