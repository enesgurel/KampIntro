using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    interface IGameService
    {
        void Add(Game game);
        void SaleGame(Game game, Gamer gamer);
        void SaleWithCampaign(Game game, Gamer gamer, Campaign campaign);
    }
}
