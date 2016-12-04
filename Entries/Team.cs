using System;
using System.Collections.Generic;
using System.Linq;

namespace Entries
{
    public class Team
    {
        public Guid Id { get; set; }

        public List<Player> Players { get; set; }

        public double Rating { get { return Players.Count != 0 ? Math.Round(Players.Average(p => p.Rating), 1) : 0; } }

        public Team()
        {
            Id = Guid.NewGuid();
            Players = new List<Player>();
        }

    }
}
