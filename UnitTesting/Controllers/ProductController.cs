using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using UnitTesting.Models;

namespace UnitTesting.Controllers
{
    public class ProductController : Controller
    {
        public static List<ProductList> productList = ProductData.GetProductDetail();
        public IActionResult Index()
        {
            return View(ProductData.GetProductDetail());
        }
        public IActionResult AddProduct(string productName, int productPrice)
        {
            productList.Add(new ProductList
            {
                    ProductName = productName,
                    ProductPrice = productPrice

            });
            return RedirectToAction("Index");


        }

        public IActionResult Summation(int Pricetotal,int Discount)
        {
            List<ProductList> list = new List<ProductList>(productList);
            productList.Clear();
            ProductViewModel productViewModel = new ProductViewModel();
            productViewModel.ProductItems = list;
            productViewModel.ProductTotal = Pricetotal;
            productViewModel.ProductDiscount = Discount;
            return View(productViewModel);
        }
        [HttpPost]
        public IActionResult Index(CustomerTypeModel customerType)
        {
            int Discount;
            int Pricetotal = Sum(customerType.Customer, productList, out Discount);
            return RedirectToAction("Summation", new { Pricetotal = Pricetotal, Discount = Discount });
        }


        public int Sum(string customerType, List<ProductList> user, out int totalDiscount)
        {
            int totalAmount = 0;
            totalDiscount = 0;

            foreach (var item in user)
            {
                if (customerType == "Regular")
                {
                    totalAmount = totalAmount + item.ProductPrice * 90 / 100;
                    totalDiscount = totalDiscount + item.ProductPrice * 10 / 100;
                }
                if (customerType == "Premium")
                {
                    totalAmount = totalAmount + item.ProductPrice * 80 / 100;
                    totalDiscount = totalDiscount + item.ProductPrice * 20 / 100;
                }

            }
            return totalAmount;
        }





    }
}