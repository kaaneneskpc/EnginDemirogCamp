using GameDemo.Entities;
using GameDemo.Interface;
using GameDemo.Manager;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Player p1 = new OldPlayer() { TcNo = "11111", PlayerName = "Kaan", MemberShipYear = 2 };
            Player p2 = new NewPlayer() { TcNo = "11112", PlayerName = "Mesut", JoinYear = 2020 };

            Games g1 = new Games() { GameName = "F1 2020", GamePrice = 100, GameReleaseYear = 2020 };
            Games g2 = new Games() { GameName = "F1 2019", GamePrice = 40, GameReleaseYear = 2019 };
            PlayerManager playerManager = new PlayerManager();
            playerManager.Add(p1);
            playerManager.Add(p2);
            List<ILoggerService> loggers = new List<ILoggerService>() { new DataLoggerService(), new FileLoggerService() };
            GameManager gameManager = new GameManager();
            gameManager.Add(g1,loggers);
            gameManager.Add(g2, new List<ILoggerService> { new DataLoggerService(), new FileLoggerService() });


            playerManager.ListPlayer();
            gameManager.ListGame();

            

            Console.WriteLine("-----------------------------");
            Console.WriteLine("Please Select for Delete User:");
            playerManager.Delete(Console.ReadLine(),new FileLoggerService());



            gameManager.ListGame();
            Console.WriteLine("Please Apply Campaign for you choose a game");
            ICampaignService campaignService = new WinterCampaign();
            string name = Console.ReadLine();
            gameManager.GetGame(name, campaignService,new DataLoggerService());



        }
    }
}
