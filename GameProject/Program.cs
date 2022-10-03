using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //GamerManager gamerManager = new GamerManager(new UserValidationManager());
            GamerManager gamerManager1 = new GamerManager(new NewEStateUserValidationManager());
            GameManager gameManager1 = new GameManager();
            CampaignManager campaignManager1 = new CampaignManager();

            gamerManager1.Add(new Gamer 
            { 
                Id = 1,
                BirthYear = 1985,
                FirstName = "ENGİN",
                LastName = "DEMİROĞ",
                IdentityNumber = 12345
            });

            Gamer gamer = new Gamer { Id = 2, BirthYear = 2001, FirstName = "Enes", LastName = "Gürel" ,IdentityNumber = 123456};
            Game testGame = new Game { GameId = 1, GameName = "TestGame", GamePrice = 25 };

            gameManager1.Add(testGame);
            gameManager1.SaleGame(testGame, gamer);

            Campaign campaign = new Campaign { CampaignId = 1, CampaignName = "Kışa MErhaba", DiscountRate = 25 };

            gameManager1.SaleWithCampaign(testGame, gamer, campaign);
        }
    }
}
