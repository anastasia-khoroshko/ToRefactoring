using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopModel
{
    public interface ICustomerDiscont
    {
        decimal GetDiscont(decimal total,int discont);
    }
}
