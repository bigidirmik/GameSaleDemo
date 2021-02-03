using GameSaleDemo.Abstract;
using GameSaleDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSaleDemo.Concrete
{
    class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine(campaign.Name + " Added!");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.Name + " Added!");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine(campaign.Name + " Added!");
        }
    }
}
