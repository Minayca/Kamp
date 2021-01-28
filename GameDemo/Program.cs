using GameDemo.Adapters;
using GameDemo.Concrete;
using GameDemo.Entities;
using System;

namespace GameDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayerManager playerManager = new PlayerManager(new MernisServiceAdapter());
            Player player1 = new Player()
            {
                DateOfBirth = new DateTime(1985, 1, 6),
                FirstName = "Engin",
                LastName = "Demiroğ",
                NationalityId = "28861499108"
            };
            playerManager.Add(player1);


            GameManager gameManager = new GameManager();
            gameManager.Add(1, "GTA V", 60.0);
            gameManager.Add(2, "Dead or Alive", 40.0);
            gameManager.Add(3, "Need for Speed", 80.0);
            gameManager.Buy(player1);

            //Campaign campaign1 = new Campaign();

            //CampaignManager campaignManager = new CampaignManager();
            //campaignManager.Add(campaign1);




        }
    }
}