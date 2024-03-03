using GameBackendSimulation.Business.Abstracts;
using GameBackendSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameBackendSimulation.Business.Concrete
{
    internal class SalesManager : ISalesManager
    {
        public void Sell(Gamer gamer, Game game, Campaign campaign)
        {
            if (campaign == null)
            {
                Console.WriteLine(gamer.Name+" Oyuncu "+game.GameName+" Adlı oyunu satın aldı");
            }
            else
            {
                Console.WriteLine(gamer.Name + "Adlı Oyuncu " + game.GameName + " Adlı oyunu  "+campaign.CampaginName+" Kampanyası ile %"+campaign.Discount+" indirimle aldı");

            }
        }
    }
}
