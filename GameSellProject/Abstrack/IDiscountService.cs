using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSellProject.Abstrack
{
    internal interface IDiscountService
    {
        string Name();
        void Discount();
    }
}
