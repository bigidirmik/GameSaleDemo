using GameSaleDemo.Abstract;
using GameSaleDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSaleDemo.Concrete
{
    class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine(game.Name + " Added!");
        }

        public void Delete(Game game)
        {
            Console.WriteLine(game.Name + " Deleted!");
        }

        public void Update(Game game)
        {
            Console.WriteLine(game.Name + " Updated!");
        }
    }
}
