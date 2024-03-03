using GameBackendSimulation.Business.Abstracts;
using GameBackendSimulation.DataAcces.Abstracts;
using GameBackendSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameBackendSimulation.Business.Concrete;

public class GamerManager:IGamerManager
{
    private readonly IGamerDal _gamerDal;
    public GamerManager(IGamerDal gamerDal)
    {

        _gamerDal = gamerDal;
    }

    public void Add(Gamer gamer)
    {
        _gamerDal.Add(gamer);
    }

    public void Update()
    {
        _gamerDal.Update();
    }

    public void Delete()
    {
        _gamerDal.Delete();
    }



}
