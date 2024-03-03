using GameBackendSimulation.Business.Abstracts;
using GameBackendSimulation.DataAcces.Abstracts;
using GameBackendSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameBackendSimulation.Business.Concrete
{
    public class CampaignManager : ICampaignManager
    {
        private readonly ICampaignDal _campaignDal;
        public CampaignManager(ICampaignDal campaignDal)
        {

            _campaignDal = campaignDal;

        }
        public void Add(Campaign campaign)
        {
            _campaignDal.Add(campaign);
        }

        public void Spend(Campaign campaign)
        {
            _campaignDal.Spend(campaign);
        }

        public void Update(Campaign campaign)
        {
            _campaignDal.Update(campaign);
        }
    }
}
