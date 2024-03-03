using GameBackendSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameBackendSimulation.Business.Abstracts;

public interface ISalesManager
{
    public void Sell(Gamer gamer,Game game,Campaign campaign);
}
