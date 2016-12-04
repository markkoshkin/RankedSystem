using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Entries;
using Extensions;

namespace Services
{
    public static class Selection
    {
        private const int MaxPlayerPerTeamFromBasket = 2;

        private static Random Random = new Random();

        public static List<Team> GetTeams(List<Player> players, int numberOfTeams)
        {
            var teams = Repeter(numberOfTeams);
            players = players.OrderByDescending(p => p.Rating).ToList();

            //rating baskets
            var baskets = Repeter(numberOfTeams);
            FillBaskets(baskets, players);

            for (int i = 0; i < baskets.Count; i++)
            {
                var pairs = GetPairs(baskets[i]);
                CompleteTeams(teams, pairs);
            }

            return teams;

        }

        private static void CompleteTeams(List<Team> teams, List<Team> pairs)
        {
            teams = teams.OrderByDescending(t => t.Rating).ToList();
            pairs = pairs.OrderBy(p => p.Rating).ToList();

            for (var i = 0; i < teams.Count; i++)
            {
                teams[i].Players.AddRange(pairs[i].Players);
            }
        }

        private static void FillBaskets(List<Team> baskets, List<Player> players)
        {
            for (int i = 0; i < baskets.Count; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    baskets[i].Players.Add(players.RemoveAndGet(0));
                }

            }
        }

        private static List<Team> GetPairs(Team basket)
        {
            var pairs = Repeter(3);
            for (var i = 0; i < pairs.Count; i++)
            {
                for (var j = 0; j < 2; j++)
                {
                    pairs[i].Players.Add(basket.Players.RemoveAndGet(Random.Next(0, basket.Players.Count - 1)));
                }
            }

            return pairs;
        }

        private static int NumberOfBasket(int numberOfPlayers, int numberOfTeams)
        {
            return (int)Math.Ceiling(Convert.ToDouble(numberOfPlayers / (numberOfTeams * MaxPlayerPerTeamFromBasket)));
        }

        private static List<Team> Repeter(int count)
        {
            var list = new List<Team>();
            for (int i = 0; i < count; i++)
            {
                list.Add(new Team());
            }

            return list;
        }
    }
}
