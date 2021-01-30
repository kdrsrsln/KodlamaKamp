using System;
using System.Collections.Generic;
using System.Text;

namespace _5GunOdev5GameSimulation
{
    interface ICampaignService
    {
        void Add(Campaign campaign);
        void Delete(Campaign campaign);
        void Update(Campaign campaign);
    }
}
