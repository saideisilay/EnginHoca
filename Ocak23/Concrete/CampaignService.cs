using Ocak23.Abstract;
using Ocak23.Entitiy;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ocak23.Concrete
{
    public class CampaignService : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("{0} nolu {1} adlı kampanya sisteme eklenmiştir.", campaign.Id, campaign.CampaignName);
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine("{0} nolu {1} adlı kampanya sistemden silinmiştir.", campaign.Id, campaign.CampaignName);
        }

        public void UpDate(Campaign campaign)
        {
            Console.WriteLine("{0} nolu {1} adlı kampanya sistemde güncellenmiştir.", campaign.Id, campaign.CampaignName);
        }
    }
}
