using CampeonatoBrasileiro.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;

namespace CampeonatoBrasileiro.Services
{
    public static class Campeonato
    {
        public static Competition competition;
        private static string Ocp_Apim_Subscription_Key = "564766b4d7bd4f878d71cbac16b3f257";
        public static Competition GetCompetitiion()
        {
            Competition competicao = new Competition();
            var client = new HttpClient();
            // Request headers
            client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", Ocp_Apim_Subscription_Key);

            // Id 15 - Campeonato Brasileiro
            var uri = "https://api.fantasydata.net/v3/soccer/scores/json/CompetitionDetails/15";
         
            HttpResponseMessage response = client.GetAsync(uri).Result;
            if (response.IsSuccessStatusCode)
            {
                var json = response.Content.ReadAsStringAsync().Result;
                competicao = JsonConvert.DeserializeObject<Competition>(json);

                uri = "https://api.fantasydata.net/v3/soccer/stats/json/PlayerSeasonStats/130";
                response = client.GetAsync(uri).Result;
                json = response.Content.ReadAsStringAsync().Result;
                List<PlayerSeason> playerSeasonStats = JsonConvert.DeserializeObject<List<PlayerSeason>>(json);
                competicao.PlayerSeasonStats = playerSeasonStats;

                uri = "https://api.fantasydata.net/v3/soccer/scores/json/TeamSeasonStats/130";
                response = client.GetAsync(uri).Result;
                json = response.Content.ReadAsStringAsync().Result;
                List<TeamSeason> teamSeasonStats = JsonConvert.DeserializeObject<List<TeamSeason>>(json);
                competicao.TeamSeasonStats = teamSeasonStats;

            }
            return competicao;
        }

        public static PlayerGame GetPlayerGameStatsByPlayer(string date, int playerId)
        {
            PlayerGame playerGame = new PlayerGame();
            var client = new HttpClient();
            // Request headers
            client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", Ocp_Apim_Subscription_Key);

            // Id 15 - Campeonato Brasileiro
            var uri = "https://api.fantasydata.net/v3/soccer/stats/xml/PlayerGameStatsByPlayer/" + date + "/" + playerId;

            HttpResponseMessage response = client.GetAsync(uri).Result;
            if (response.IsSuccessStatusCode)
            {
                var json = response.Content.ReadAsStringAsync().Result;
                playerGame = JsonConvert.DeserializeObject<PlayerGame>(json);
            }
            return playerGame;
        }

        public static TeamGame GetTeamGameStats(string date)
        {
            TeamGame teamGame = new TeamGame();
            var client = new HttpClient();
            // Request headers
            client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", Ocp_Apim_Subscription_Key);

            // Id 15 - Campeonato Brasileiro
            var uri = "https://api.fantasydata.net/v3/soccer/stats/xml/TeamGameStatsByDate/" + date;

            HttpResponseMessage response = client.GetAsync(uri).Result;
            if (response.IsSuccessStatusCode)
            {
                var json = response.Content.ReadAsStringAsync().Result;
                teamGame = JsonConvert.DeserializeObject<TeamGame>(json);
            }
            return teamGame;
        }

        public static BoxScore GetBoxScore(int gameId)
        {
            BoxScore boxScore = new BoxScore();
            var client = new HttpClient();
            // Request headers
            client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", Ocp_Apim_Subscription_Key);

            // Id 15 - Campeonato Brasileiro
            var uri = "https://api.fantasydata.net/v3/soccer/stats/json/BoxScore/" + gameId;

            HttpResponseMessage response = client.GetAsync(uri).Result;
            if (response.IsSuccessStatusCode)
            {
                var json = response.Content.ReadAsStringAsync().Result;
                List<BoxScore> box = JsonConvert.DeserializeObject<List<BoxScore>>(json);
                boxScore = box.FirstOrDefault();
            }
            return boxScore;
        }

        public static Tabela GetTabela()
        {
            Tabela tabela = new Tabela();
            List<Game> rodada = new List<Game>();
            foreach (var time in competition.Teams)
            {
                int p = 0, j = 0, v = 0, d = 0, e = 0, gp = 0, gc = 0, sg = 0, gol = 0;
                string ultimosJogos = "";
                Classificacao classificacao = new Classificacao();
                var jogos = competition.Games.Where(g => g.AwayTeamId == time.TeamId || g.HomeTeamId == time.TeamId).ToList();
                foreach (var jogo in jogos)
                {
                    if (jogo.Status != "Scheduled")
                    {
                        j += 1;
                        if (jogo.AwayTeamId == time.TeamId)
                        {
                            if (jogo.AwayTeamScore > jogo.HomeTeamScore)
                            {
                                v += 1;
                                p += 3;
                                ultimosJogos += "V";
                            }
                            if (jogo.AwayTeamScore == jogo.HomeTeamScore)
                            {
                                e += 1;
                                p += 1;
                                ultimosJogos += "E";
                            }
                            if (jogo.AwayTeamScore < jogo.HomeTeamScore)
                            {
                                d += 1;
                                ultimosJogos += "D";
                            }
                            gol = jogo.AwayTeamScore.HasValue ? jogo.AwayTeamScore.Value : 0;
                            gp += gol;
                            gol = jogo.HomeTeamScore.HasValue ? jogo.HomeTeamScore.Value : 0;
                            gc += gol;
                        }
                        if (jogo.HomeTeamId == time.TeamId)
                        {
                            if (jogo.HomeTeamScore > jogo.AwayTeamScore)
                            {
                                v += 1;
                                p += 3;
                                ultimosJogos += "V";
                            }
                            if (jogo.HomeTeamScore == jogo.AwayTeamScore)
                            {
                                e += 1;
                                p += 1;
                                ultimosJogos += "E";
                            }
                            if (jogo.HomeTeamScore < jogo.AwayTeamScore)
                            {
                                d += 1;
                                ultimosJogos += "D";
                            }
                            gol = jogo.HomeTeamScore.HasValue ? jogo.HomeTeamScore.Value : 0;
                            gp += gol;
                            gol = jogo.AwayTeamScore.HasValue ? jogo.AwayTeamScore.Value : 0;
                            gc += gol;
                        }
                    }
                }
                sg = gp - gc;
                classificacao.Time = time.Name;
                classificacao.Ponto = p;
                classificacao.Jogo = j;
                classificacao.Vitoria = v;
                classificacao.Empate = e;
                classificacao.Derrota = d;
                classificacao.GolPro = gp;
                classificacao.GolContra = gc;
                classificacao.SaldoGol = sg;
                double a = (double)(p * 100) / (j * 3);
                classificacao.Aproveitamento = a;
                classificacao.UltimosJogos = ultimosJogos;
                tabela.Classificacao.Add(classificacao);
            }
            var index = tabela.Classificacao.OrderByDescending(t => t.Ponto)
                .ThenByDescending(t => t.Vitoria)
                .ThenByDescending(t => t.SaldoGol)
                .ThenByDescending(t => t.GolPro)
                .ToList();
            tabela.Classificacao = index;
            foreach(var jogo in competition.Games)
            {
                if (jogo.Week == competition.CurrentSeason.Rounds.FirstOrDefault().CurrentWeek)
                {
                    jogo.HomeTeam = competition.Teams.Where(t => t.TeamId == jogo.HomeTeamId).FirstOrDefault();
                    jogo.AwayTeam = competition.Teams.Where(t => t.TeamId == jogo.AwayTeamId).FirstOrDefault();
                    rodada.Add(jogo);
                }
            }
            var artilharia = from player in competition.PlayerSeasonStats
                             .Where(p=> p.Goals > 0)
                             .OrderByDescending(p => p.Goals)
                             select player;
            tabela.Artilharia = artilharia.ToList();
            tabela.Jogos = rodada;
            return tabela;
        }
    }

}