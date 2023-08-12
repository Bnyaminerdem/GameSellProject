using GameSellProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace GameSellProject.Abstrack
{
    internal interface IGameService
    {
        void Sell(Game game, Player player);
    }
}
