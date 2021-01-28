using GameDemo.Abstract;
using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Concrete
{
    class GameManager : Market
    {
        private List<Game> Games = new List<Game>();

        public void Add(int id, string name, double price)
        {
            Game game = new Game();
            game.Id = id;
            game.Name = name;
            game.Price = price;

            Games.Add(game);

            Console.WriteLine("Oyun eklendi: " + game.Name);

        }

        public void Update(Game game)
        {
            Console.WriteLine("Oyun güncellendi: " + game.Name);
            Games.Add(game);
        }

        public void Delete(Game game)
        {
            Console.WriteLine("Oyun silindi: " + game.Name);
        }

        public void Buy(Player player)
        {
            Console.WriteLine("\n");
            Console.WriteLine(player.FirstName+" "+player.LastName+" aldığınız oyunlar: ");
            double tutar = 0;
            foreach (var game in Games)
            {
                Console.WriteLine(game.Name);
                tutar += game.Price;
            }
            Console.WriteLine("Tutar: " + tutar);
        }
    }
}
