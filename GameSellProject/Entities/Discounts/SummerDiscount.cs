using GameSellProject.Abstrack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSellProject.Entities.Discounts
{
    internal class SummerDiscount : IDiscountService
    {
        public string Name()
        {
            return "Summer Discount";
        }

        public void Discount()
        {
            Console.WriteLine(">Sadece yaz aylarında geçerli Yaz indirimi'nden yararlandınız!");
        }
    }
}
