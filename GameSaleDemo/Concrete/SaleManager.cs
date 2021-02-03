using GameSaleDemo.Abstract;
using GameSaleDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSaleDemo.Concrete
{
    class SaleManager : ISaleService
    {
        public void Sell(Gamer gamer, Game game, Campaign campaign)
        {
            Console.WriteLine(gamer.Name + " " + gamer.Surname + ", " + game.Name + " adındaki oyunu " + campaign.Name + " kampanyası ile " + game.Price*campaign.Discount + " TL'ye satın aldı.");
        }
    }
}
