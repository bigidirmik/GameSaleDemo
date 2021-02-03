using GameSaleDemo.Abstract;
using GameSaleDemo.Concrete;
using GameSaleDemo.Entities;
using System;

namespace GameSaleDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer1 = new Gamer();
            gamer1.Id = 1;
            gamer1.Name = "Bilal";
            gamer1.Surname = "Dırmık";
            gamer1.NationalityId = "12345678901";
            gamer1.DateOfBirth = "1993";

            Gamer gamer2 = new Gamer();
            gamer2.Id = 2;
            gamer2.Name = "Hikmet";
            gamer2.Surname = "Dırmık";
            gamer2.NationalityId = "12365478910";
            gamer2.DateOfBirth = "1992";


            Game game1 = new Game();
            game1.Id = 1;
            game1.Name = "Squad";
            game1.Price = 50;

            Game game2 = new Game();
            game2.Id = 2;
            game2.Name = "PUBG";
            game2.Price = 80;


            Campaign campaign1 = new Campaign();
            campaign1.Id = 1;
            campaign1.Name = "Winter Sale";
            campaign1.Discount = 0.5;

            Campaign campaign2 = new Campaign();
            campaign2.Id = 2;
            campaign2.Name = "Black Friday";
            campaign2.Discount = 0.35;


            Console.WriteLine("-----------Steam Store------------");
            BaseGamerManager gamerManager2 = new SteamGamerManager(new ValidationManager());
            gamerManager2.Add(gamer1);

            Console.WriteLine("------------Epic Store------------");
            BaseGamerManager gamerManager1 = new EpicGamerManager();
            gamerManager1.Add(gamer2);


            Console.WriteLine("------------GameManage------------");
            GameManager gameManager = new GameManager();
            gameManager.Add(game1);
            gameManager.Add(game2);


            Console.WriteLine("-----------Campaigns------------");
            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign1);
            campaignManager.Add(campaign2);


            Console.WriteLine("-----------Selling------------");
            SaleManager saleManager = new SaleManager();
            saleManager.Sell(gamer1,game1,campaign1);
            saleManager.Sell(gamer2, game2, campaign2);
        }
    }
}
