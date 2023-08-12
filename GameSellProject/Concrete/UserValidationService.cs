using GameSellProject.Abstrack;
using GameSellProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSellProject.Concrete
{
    internal class UserValidationService :IUserValidationService
    {      
        bool IUserValidationService.CheckIfRealPerson(Player player)
        {
           return true;
        }
    }
}
