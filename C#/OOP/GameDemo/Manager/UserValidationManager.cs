using GameDemo.Entities;
using GameDemo.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Manager
{
    class UserValidationManager : IUserValidation
    {
        

        public void ValidatePlayer(Player players)
        {
            if(players.TcNo == null)
            {
                Console.WriteLine("Invalid User");
            }
            else
            {
                Console.WriteLine("Welcome"+" "+players.PlayerName);
            }
        }
    }
}
