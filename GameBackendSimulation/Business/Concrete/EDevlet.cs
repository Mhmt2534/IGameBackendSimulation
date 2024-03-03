using GameBackendSimulation.Business.Abstracts;
using GameBackendSimulation.Entities;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameBackendSimulation.Business.Concrete;

public class EDevlet:IEDevlet
{
    public bool ExistControl(Gamer gamer)
    {
        KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
        return client.TCKimlikNoDogrulaAsync(new TCKimlikNoDogrulaRequest(new TCKimlikNoDogrulaRequestBody(gamer.Id, gamer.Name, gamer.SureName, gamer.DateOfBirthYear))).Result.Body.TCKimlikNoDogrulaResult;
    }
}
