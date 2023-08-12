using GameSellProject.Abstrack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSellProject.Entities.Games
{
    internal class CsGoManager:IGameService
    {
        public void Sell(Game game, Player player)
        {
            Console.WriteLine(">Counter-Strike: Global Offensive Satın Alındı.");
        }
    }
}

