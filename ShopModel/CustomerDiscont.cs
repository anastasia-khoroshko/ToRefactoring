using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopModel
{
    public class CustomerDiscont:ICustomerDiscont
    {
        public decimal GetDiscont(decimal total,int discont)
        {
            return total - total *discont/100;
        }
    }
}
