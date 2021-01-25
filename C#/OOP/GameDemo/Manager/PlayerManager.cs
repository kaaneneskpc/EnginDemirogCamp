using GameDemo.Entities;
using GameDemo.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Manager
{
    class PlayerManager
    {
        List<Player> players = new List<Player>() { };

        public void Add(Player player)
        {
            players.Add(player);
            Console.WriteLine("Player Added " +" "+ player.PlayerName);
        }
        public void Update(Player player)
        {

        }

        public void Delete(string TcNo,ILoggerService loggerService)
        {
            foreach(var player in players)
            {
                if (player.TcNo == TcNo)
                {
                    players.Remove(player);
                    Console.WriteLine("Deleted" +" "+player.PlayerName);
                    loggerService.Log();
                    break;
                }
                else
                {
                    continue;
                }
            }   
        }
        public void ListPlayer()
        {
            
            foreach (var player in players)
            {
                Console.WriteLine("User : "+" "+player.PlayerName+" "+player.TcNo+" "+player.JoinYear);
            }
        }
    }
}
