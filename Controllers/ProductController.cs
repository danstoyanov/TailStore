using System;
using System.Collections.Generic;
using System.Linq;

using Microsoft.AspNetCore.Mvc;

using TailStore.Data;
using TailStore.Data.Entities;
using TailStore.Web.Models.Products;

namespace TailStore.Web.Controllers
{
    public class ProductController : Controller
    {
        private readonly TailStoreDbContext data;

        public ProductController(TailStoreDbContext data)
        {
            this.data = data;
        }

        public IActionResult ListedProducts()
        {
            return View();
        }

        public IActionResult AddProduct()
        {
            var product = new Product
            {
                Id = Guid.NewGuid().ToString().Split("-").FirstOrDefault(),
                Title = "Happy Belly Honey Graham Crackers, 14.4 Ounce",
                Price = 3.99,
                ImageUrl = "https://m.media-amazon.com/images/I/81uuzlWpAFL._SY879_.jpg"
            };

            this.data.Products.Add(product);
            this.data.SaveChanges();

            return View();
        }

        public IActionResult AdminProducts()
        {

            var viewProducts = this.data.Products.Select(p => new ProductViewModel
            {
                Id = p.Id,
                Name = p.Title,
                Price = p.Price,
                ImageUrl = p.ImageUrl,
            })
            .ToList();

            // Test to add employee in the Database!
            //var product = new Product
            //{
            //    Id = "12345",
            //    Title = "Doritos Pickel and Cool Ranch Collisions",
            //    Price = 1.99,
            //    ImageUrl = "https://m.media-amazon.com/images/I/61yebrQm1yL._SL1080_.jpg"
            //};

            //this.data.Products.Add(product);
            //this.data.SaveChanges();

            return View(viewProducts);
        }

        [HttpPost]
        public IActionResult DeleteProduct(string Id)
        {
            var currentProduct = this.data.Products
                .FirstOrDefault(p => p.Id == Id);

            this.data.Products.Remove(currentProduct);
            this.data.SaveChanges();

            return RedirectToAction("AdminProducts");
        }
    }
}


// Doritos Pickel and Cool Ranch Collisions
// 2.89
// https://m.media-amazon.com/images/I/61yebrQm1yL._SL1080_.jpg  


// Test to add rpoducts in the Database!
//var product = new Product
//{
//    Id = "12345",
//    Title = "Doritos Pickel and Cool Ranch Collisions",
//    Price = 1.99,
//    ImageUrl = "https://m.media-amazon.com/images/I/61yebrQm1yL._SL1080_.jpg"
//};

//var product2 = new Product
//{
//    Id = "123456",
//    Title = "Ben & Jerry's Milk & Cookies Vanilla Ice Cream Pint Non-GMO",
//    Price = 3.99,
//    ImageUrl = "https://m.media-amazon.com/images/I/81oa7rAM9-L._SL1500_.jpg"
//};

//var product3 = new Product
//{
//    Id = "1234567",
//    Title = "Hellmann's Real Mayonnaise Squeeze Bottle For A Rich Creamy Condiment Gluten Free, Made With 100% Cage-Free Eggs 20oz",
//    Price = 2.49,
//    ImageUrl = "https://m.media-amazon.com/images/I/71qp6FXhQZL._SL1500_.jpg"
//};

//this.data.Products.Add(product);
//this.data.Products.Add(product2);
//this.data.Products.Add(product3);
//this.data.SaveChanges();