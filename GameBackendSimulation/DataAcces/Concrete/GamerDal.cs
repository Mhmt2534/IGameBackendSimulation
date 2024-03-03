using GameBackendSimulation.Business.Abstracts;
using GameBackendSimulation.DataAcces.Abstracts;
using GameBackendSimulation.Entities;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameBackendSimulation.DataAcces.Concrete;

public class GamerDal : IGamerDal
{
    private IEDevlet _eDevlet;
    public GamerDal(IEDevlet eDevlet)
    {
        _eDevlet = eDevlet;
    }

    public void Add(Gamer gamer)
    {
        if (_eDevlet.ExistControl(gamer))
        {
            Console.WriteLine("Oyuncu eklendi");
        }
        else {
            Console.WriteLine("Oyuncu Eklenemedi. Bilgilerinizi tekrar kontrol ediniz");
        }
    }


    public void Delete()
    {
        Console.WriteLine("Oyuncu silindi");
    }

    public void Update()
    {
        Console.WriteLine("Oyuncu güncellendi");
    }



}
