using GameSellProject.Abstrack;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSellProject.Entities.Discounts
{
    internal class ChristmasDiscount : IDiscountService
    {
        public string Name()
        {
            return "Christmas Discount";
        }

        public void Discount()
        {
            Console.WriteLine(">Tebrikler, Sadece Yılbaşında Olan Yılbaşı İndiriminden yararlandınız");
        }
    }
}
