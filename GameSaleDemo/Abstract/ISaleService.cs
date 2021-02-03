using GameSaleDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSaleDemo.Abstract
{
    public interface ISaleService
    {
        void Sell(Gamer gamer, Game game, Campaign campaign);
    }
}
