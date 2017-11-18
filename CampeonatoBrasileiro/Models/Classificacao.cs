using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CampeonatoBrasileiro.Models
{
    public class Classificacao
    {
        public string Time { get; set; }
        public int Ponto { get; set; }
        public int Jogo { get; set; }
        public int Vitoria { get; set; }
        public int Empate { get; set; }
        public int Derrota { get; set; }
        public int GolPro { get; set; }
        public int GolContra { get; set; }
        public int SaldoGol { get; set; }
        public double Aproveitamento { get; set; }
        public string UltimosJogos { get; set; }
    }
}