using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShopModel
{
    public class ValueCalculator:IValueCalculator
    {
        public decimal ValueProducts(IEnumerable<Product> products)
        {
            if (products.Count() == 0) throw new CustomException("No items in shopping cart!");
            decimal sumOfProduct = 0;
            foreach (var product in products)
            {
                sumOfProduct += product.Price;
            }
            return sumOfProduct;
        }
    }
}
