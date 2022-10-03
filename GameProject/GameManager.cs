using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine("{0} İsimli oyun mağazaya eklendi!", game.GameName);
        }

        public void SaleGame(Game game, Gamer gamer)
        {
            Console.WriteLine("{0} isimli oyun mağazadan {1} tarafından satın alındı!", game.GameName, gamer.FirstName + " " + gamer.LastName);
        }

        public void SaleWithCampaign(Game game, Gamer gamer, Campaign campaign)
        {
            Console.WriteLine("{0} isimli oyun mağazadan {1} tarafından {2} kampanyası dahilinde %{3} indirimli şekilde satın alındı!", 
                game.GameName, gamer.FirstName + " " + gamer.LastName, campaign.CampaignName, campaign.DiscountRate);
        }
    }
}
