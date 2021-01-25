using GameDemo.Entities;
using GameDemo.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Manager
{
    class GameManager
    {
        List<Games> games = new List<Games>() { };

        public void Add(Games game,List<ILoggerService> loggerServices)
        {
            games.Add(game);
            Console.WriteLine("Added : " +" "+game.GameName);
            foreach (var item in loggerServices)
            {
                item.Log();
            }
            
        }

        public void Update(Games game)
        {

        }

        public void Delete(string GameName)
        {

            foreach (var game in games)
            {
                if (game.GameName == GameName)
                {
                    games.Remove(game);
                    Console.WriteLine("Removed." +" "+game.GameName);
                    break;
                }

                else
                {
                    continue;
                }
            }


        }
        public void ListGame()
        {
            
            foreach (var game in games)
            {
               
                Console.WriteLine("Game : "+" "+game.GameName +" "+ game.GameReleaseYear +" "+game.GamePrice);
                
                
            }
        }

        public void GetGame(string GameName,ICampaignService campaignService,ILoggerService loggerService)
        {
            foreach(var game in games)
            {
                if (game.GameName == GameName)
                {
                    campaignService.CalcSale(game);
                    campaignService.SaleInfo(game);
                    loggerService.Log();
                }
                else
                {
                    continue;
                }
            }
        }
    }
}
