using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CampeonatoBrasileiro.Models
{
    public class Tabela
    {
        public IList<Classificacao> Classificacao { get; set; }
        public IList<Game> Jogos { get; set; }
        public IList<PlayerSeason> Artilharia { get; set; }
        public Tabela()
        {
            Classificacao = new List<Classificacao>();
            Jogos = new List<Game>();
        }
    }
}