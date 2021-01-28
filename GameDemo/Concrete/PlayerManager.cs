using GameDemo.Abstract;
using GameDemo.Adapters;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Concrete
{
    public class PlayerManager : BasePlayerManager
    {
        private IPlayerCheckService _playerCheckService;

        public PlayerManager(IPlayerCheckService playerCheckService)
        {
            _playerCheckService = playerCheckService;
        }

        public void Add(Player player)
        {
            if (_playerCheckService.CheckIfRealPerson(player))
            {
                base.Add(player);
            }
            else
            {
                throw new Exception("Not a valid person.");
            }
        }
        public void Update(Player player)
        {
            Console.WriteLine("Oyuncu güncellendi: " + player.FirstName + " " + player.LastName);
        }

        public void Delete(Player player)
        {
            Console.WriteLine("Oyuncu silindi: " + player.FirstName + " " + player.LastName);
        }
    }
}
