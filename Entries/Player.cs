using System;

namespace Entries
{
    public class Player
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public double Rating { get; set; }
        
        public Player()
        {
            Id = Guid.NewGuid();
            Surname = "";
        }
    }
}
