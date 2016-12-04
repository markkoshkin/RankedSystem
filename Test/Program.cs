using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Entries;
using Services;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            var players = new List<Player>
            {
                new Player
                {
                    Name = "Віталій Корнилюк",
                    Rating = 4.4
                },
                new Player
                {
                    Name = "Богдан Барановський",
                    Rating = 6.3
                },
                new Player
                {
                    Name = "Ткачук Артем",
                    Rating = 8.5
                },
                new Player
                {
                    Name = "Лапік Андрій",
                    Rating = 5.1
                },
                new Player
                {
                    Name = "Петя Павлович",
                    Rating = 3.4
                },
                new Player
                {
                    Name = "Доброцький Віталій",
                    Rating = 6.9
                },
                new Player
                {
                    Name = "Дмитрий Иваницкий",
                    Rating = 5.8
                },
                new Player
                {
                    Name = "Марк Динамо",
                    Rating = 5.5
                },
                new Player
                {
                    Name = "Соколов Алексей",
                    Rating = 4.4
                },
                new Player
                {
                    Name = "Солонець Віктор",
                    Rating = 4.1
                },
                new Player
                {
                    Name = "Зубенко Герман",
                    Rating = 4.0
                },
                new Player
                {
                    Name = "Идзинский Борис",
                    Rating = 5.0
                },
                new Player
                {
                    Name = "Віталій Прокопенко",
                    Rating = 7.2
                },
                new Player
                {
                    Name = "Керов Александр",
                    Rating = 4.7
                },
                new Player
                {
                    Name = "Рудик Міша",
                    Rating = 4.6
                },
                new Player
                {
                    Name = "Бокач Євген",
                    Rating = 8.3
                },
                new Player
                {
                    Name = "Олексій Апанасенко",
                    Rating = 7.7
                },
                new Player
                {
                    Name = "Ткачик Олександр",
                    Rating = 2.9
                }
            };

            for (int i = 0; i < 3; i++)
            {
                var teams = Selection.GetTeams(players, 3);
                Console.WriteLine("Result");
                foreach (var team in teams)
                {
                    Console.WriteLine("Rating : " + team.Rating);
                    foreach (var player in team.Players)
                    {
                        Console.WriteLine(string.Format("Name : {0}, Rating {1}", player.Name, player.Rating));
                    }
                }
                Console.WriteLine();
                Console.WriteLine();
            }
           
            Console.ReadKey();
        }
    }
}
