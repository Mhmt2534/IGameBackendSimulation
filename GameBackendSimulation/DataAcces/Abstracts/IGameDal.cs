﻿using GameBackendSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameBackendSimulation.DataAcces.Abstracts;

public interface IGameDal
{
    public void Add(Game game);
    public void Update(Game game);
    public void Delete(Game game);
}
