using GameBackendSimulation.Business.Abstracts;
using GameBackendSimulation.Business.Concrete;
using GameBackendSimulation.DataAcces.Concrete;
using GameBackendSimulation.Entities;

Gamer gamer = new Gamer();
gamer.Id = 21566177296;
gamer.Name = "Mahmut";
gamer.SureName = "Güneş";
gamer.DateOfBirthYear = 2003;

Campaign campaign = new Campaign();
campaign.CampaginName = "Genç";
campaign.Discount = 10;

Game game = new Game();
game.GameName = "God Of War";
game.GId = 1;
game.Price = 300;


GamerManager gamerManager = new GamerManager(new GamerDal(new EDevlet()));

gamerManager.Add(gamer);

Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("");

SalesManager salesManager = new SalesManager();
salesManager.Sell(gamer,game,campaign);
