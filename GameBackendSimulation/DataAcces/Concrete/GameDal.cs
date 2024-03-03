using GameBackendSimulation.DataAcces.Abstracts;
using GameBackendSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameBackendSimulation.DataAcces.Concrete
{
    public class GameDal : IGameDal
    {
        public void Add(Game game)
        {
            Console.WriteLine(game.GameName+"Adlı Eklendi");
        }

        public void Delete(Game game)
        {
            Console.WriteLine(game.GameName + "Adlı Silindi");
        }

        public void Update(Game game)
        {
            Console.WriteLine(game.GameName + "Adlı Güncellendi");
        }
    }
}
