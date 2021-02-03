using GameSaleDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSaleDemo.Abstract
{
    public abstract class BaseGamerManager : IGamerService
    {
        public virtual void Add(Gamer gamer)
        {
            Console.WriteLine(gamer.Name + " Added!");
        }

        public virtual void Delete(Gamer gamer)
        {
            Console.WriteLine(gamer.Name + " Deleted!");
        }

        public virtual void Update(Gamer gamer)
        {
            Console.WriteLine(gamer.Name + " Updated!");
        }
    }
}
