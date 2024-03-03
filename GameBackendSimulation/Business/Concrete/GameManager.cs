using GameBackendSimulation.Business.Abstracts;
using GameBackendSimulation.DataAcces.Abstracts;
using GameBackendSimulation.DataAcces.Concrete;
using GameBackendSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameBackendSimulation.Business.Concrete
{
    public class GameManager : IGameManager
    {
        private readonly IGameDal _gameDal;
        public GameManager(GameDal gameDal)
        {
            _gameDal = gameDal;
        }

        public void Add(Game game)
        {
            _gameDal.Add(game);
        }

        public void Delete(Game game)
        {
            _gameDal.Delete(game);

        }

        public void Update(Game game)
        {
            _gameDal.Update(game);
        }
    }
}
