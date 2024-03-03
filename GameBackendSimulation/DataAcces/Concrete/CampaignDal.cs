using GameBackendSimulation.DataAcces.Abstracts;
using GameBackendSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameBackendSimulation.DataAcces.Concrete;

internal class CampaignDal : ICampaignDal
{
    public void Add(Campaign campaign)
    {
        Console.WriteLine(campaign.CampaginName+"Adlı kampanya eklendi");
    }

    public void Spend(Campaign campaign)
    {
        Console.WriteLine(campaign.CampaginName + "Adlı kampanya harcandı");
    }

    public void Update(Campaign campaign)
    {
        Console.WriteLine(campaign.CampaginName + "Adlı kampanya güncellendi");
    }
}
