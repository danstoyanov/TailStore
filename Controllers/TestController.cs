using Microsoft.AspNetCore.Mvc;

namespace TailStore.Web.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Test()
        {
            return View();
        }
    }
}
