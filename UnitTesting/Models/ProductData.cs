using System.Collections.Generic;

namespace UnitTesting.Models
{
    public class ProductData
    {
        public static List<ProductList> GetProductDetail()
        {
            return new List<ProductList>
            {
                new ProductList
                {
                    ProductId=1,
                    ProductName="Biscuits",
                    ProductPrice=230

                },
                new ProductList
                {
                    ProductId=2,
                    ProductName="Vegetables",
                    ProductPrice=230

                },
                new ProductList
                {
                    ProductId=3,
                    ProductName="Cheese",
                    ProductPrice=20

                },
                new ProductList
                {
                    ProductId=4,
                    ProductName="Fruits",
                    ProductPrice=456

                }, new ProductList
                {
                    ProductId=5,
                    ProductName="Milk",
                    ProductPrice=30

                },
                new ProductList
                {
                    ProductId=6,
                    ProductName="Toys",
                    ProductPrice=300

                },
                new ProductList
                {
                    ProductId=7,
                    ProductName="Chips",
                    ProductPrice=30

                },
                new ProductList
                {
                    ProductId=8,
                    ProductName="Soap",
                    ProductPrice=30

                },
                new ProductList
                {
                    ProductId=9,
                    ProductName="Soap",
                    ProductPrice=30

                },
                new ProductList
                {
                    ProductId=10,
                    ProductName="Milk",
                    ProductPrice=30

                }
            };

        }
       
       
            

    }
}
