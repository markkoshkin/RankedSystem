﻿using System.Collections.Generic;
using Entries;
using NUnit.Framework;
using Services;

namespace ServicesTest
{
    [TestFixture]
    public class SelectionTest
    {
        [Test]
        public void TeamSelection()
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
                    Name = "",
                    Rating = 3.4
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

            var teams = Selection.GetTeams(players, 3);
            Assert.IsNotEmpty(teams);
        }

    }
}
