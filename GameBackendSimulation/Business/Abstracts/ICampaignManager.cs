using GameBackendSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameBackendSimulation.Business.Abstracts;

public interface ICampaignManager
{
    public void Add(Campaign campaign);
    public void Update(Campaign campaign);
    public void Spend(Campaign campaign);

}
