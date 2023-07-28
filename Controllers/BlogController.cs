using Microsoft.AspNetCore.Mvc;

namespace TailStore.Web.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult BlogView()
        {
            return View();
        }
    }
}
