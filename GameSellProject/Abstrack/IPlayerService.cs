using GameSellProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace GameSellProject.Abstrack
{
    internal interface IPlayerService
    {
        void Add(Player player);
        void Update(Player player);
        void Delete(Player player);
        bool CheckIfRealPerson(Player player);
    }
}
