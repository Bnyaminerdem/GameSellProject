using GameSellProject.Abstrack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSellProject.Entities.Games
{
    internal class BlazingSailsManager : IGameService
    { 

        public void Sell(Game game, Player player)
        {
            Console.WriteLine(">Blazing Sails Satın alındı.");
        }
    }
}
