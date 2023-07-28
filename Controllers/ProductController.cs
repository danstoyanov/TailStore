using Microsoft.AspNetCore.Mvc;
using TailStore.Data;
using TailStore.Data.Entities;

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

            return View();
        }
    }
}


// Doritos Pickel and Cool Ranch Collisions
// 2.89
// https://m.media-amazon.com/images/I/61yebrQm1yL._SL1080_.jpg  