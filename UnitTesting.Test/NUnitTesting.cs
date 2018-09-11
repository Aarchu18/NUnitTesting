using NUnit.Framework;
using System.Collections.Generic;
using UnitTesting.Controllers;
using UnitTesting.Models;

namespace UnitTesting.Test
{
    [TestFixture]
    public class NUnitTesting
    {
        [Test]
        [TestCase("Regular")]
        [TestCase("Premium")]
        public void NUnitTest(string customerType)
        {
            //Arrange
            ProductController productController = new ProductController();
            int ProductDiscount = 0;
            int ProductTotalPrice = 0;
            List<ProductList> productList = new List<ProductList>
            {
                 new ProductList
                {
                   ProductName="Biscuits",
                   ProductPrice=600
                },
               new ProductList
               {
                   ProductName="Milk",
                   ProductPrice=50
               },
               new ProductList
               {
                   ProductName="Cheese",
                   ProductPrice=40
               },
               new ProductList
               {
                   ProductName="DairyMilk",
                   ProductPrice=120
               },
               new ProductList
               {
                   ProductName="Mouse",
                   ProductPrice=500
               },
            };
            //Act
            foreach (var data in productList)
            {
                if (customerType == "Premium")
                {
                    ProductTotalPrice = ProductTotalPrice + data.ProductPrice * 80 / 100;
                    ProductDiscount = ProductDiscount + data.ProductPrice * 20 / 100;
                }
                if (customerType == "Regular")
                {
                    ProductTotalPrice = ProductTotalPrice + data.ProductPrice * 90 / 100;
                    ProductDiscount = ProductDiscount + data.ProductPrice * 10 / 100;
                }
            }
        }
    }
}