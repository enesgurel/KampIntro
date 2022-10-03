using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("{0} isimli kampanya sisteme tanımlandı.", campaign.CampaignName);
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine("{0} isimli kampanya sistemden silindi.", campaign.CampaignName);
        }

        public void MakeDiscount(Campaign campaign, Game game)
        {
            Console.WriteLine("{0} isimli oyuna {1} kampanyası tanımlandı.", campaign.CampaignName, game.GameName);
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("{0} isimli kampanyada güncelleme yapıldı.", campaign.CampaignName);
        }
    }
}
