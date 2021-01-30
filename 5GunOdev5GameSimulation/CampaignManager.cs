using System;
using System.Collections.Generic;
using System.Text;

namespace _5GunOdev5GameSimulation
{
    class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine(campaign.Name + " campain added!");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.Name + " campain deleted!");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine(campaign.Name + " campain updated!");
        }
    }
}
