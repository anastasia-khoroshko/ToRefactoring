using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopModel
{
    public class ShoppingCart
    {
        private IValueCalculator _valueCalc;
        private ICustomerDiscont _custDiscont;

        public IEnumerable<Product> Products { get; set; }
        public int Discont { get; set; }

        public ShoppingCart(IValueCalculator valueCalc, ICustomerDiscont custDiscont)
        {
            this._valueCalc = valueCalc;
            this._custDiscont = custDiscont;
        }

        public decimal CalculateProductTotal()
        {
            return _valueCalc.ValueProducts(Products);
        }
        public decimal GetDiscont()
        {
            if (Discont == null) throw new CustomException("Discont don't have value");
            decimal total = CalculateProductTotal();            
            return _custDiscont.GetDiscont(total,Discont);
        }
    }
}
