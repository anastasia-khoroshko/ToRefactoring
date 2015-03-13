using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShopModel;
using Moq;
using System.Collections.Generic;

namespace TestShopModel
{
    [TestClass]
    public class TestShoppingCart
    {
        [TestMethod]
        public void TestCalculateTotal()
        {
            var valCalc = new Mock<IValueCalculator>();
            var valDiscont = new Mock<ICustomerDiscont>();
            var cart = new ShoppingCart(valCalc.Object, valDiscont.Object);
            cart.Products = new List<Product>()
                {
                    new Product {Name = "Product 1", Category = "C1", Description = "no", ProductID = 1, Price = 100},
                    new Product {Name = "Product 2", Category = "C2", Description = "no", ProductID = 2, Price = 200}
                };
            cart.Discont = 5;
            Assert.AreEqual(cart.CalculateProductTotal(), 300M);
        }
    }
}
