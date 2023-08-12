using GameSellProject.Abstrack;
using GameSellProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace GameSellProject.Concrete
{
    internal class GameManager : IGameService
    {
        public void Sell(Game game, Player player)
        {
            Console.WriteLine($"Oyun satıldı: {game.GameName} - {player.FirstName} {player.LastName}");
        }
    }
}
