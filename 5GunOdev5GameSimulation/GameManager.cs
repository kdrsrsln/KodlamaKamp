using System;
using System.Collections.Generic;
using System.Text;

namespace _5GunOdev5GameSimulation
{
    class GameManager : IGameService
    {
        public void Purchase(Game game, Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " purchased " + game.Name);
        }
    }
}
