using GameSellProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSellProject.Abstrack
{
    internal interface IUserValidationService
    {
        bool CheckIfRealPerson(Player player);
    }
}
