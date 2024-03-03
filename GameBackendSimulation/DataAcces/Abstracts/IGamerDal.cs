using GameBackendSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameBackendSimulation.DataAcces.Abstracts;

public interface IGamerDal
{
    public void Add(Gamer gamer);
    public void Update();
    public void Delete();

}
