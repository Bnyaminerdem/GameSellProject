using GameSellProject.Abstrack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSellProject.Entities.Discounts
{
    internal class WelcomeDiscount : IDiscountService
    {
        public string Name()
        {
            return "Welcome Discount";
        }

        public void Discount()
        {
            Console.WriteLine(">Yeni katılan oyuncularımızın yararlanabildiği Hoşgeldin İndirimi'nden yararlandınız!");
        }
    }
}
