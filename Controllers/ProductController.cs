using Microsoft.AspNetCore.Mvc;

namespace TailStore.Web.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult ListedProducts()
        {
            return View();
        }
    }
}
