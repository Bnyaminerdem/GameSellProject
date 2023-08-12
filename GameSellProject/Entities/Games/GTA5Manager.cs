using GameSellProject.Abstrack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSellProject.Entities.Games
{
    internal class GTA5Manager : IGameService
    {
        public void Sell(Game game, Player player)
        {
            Console.WriteLine(">Grand Theft Auto V Satın Alındı.");
        }
    }
}
s