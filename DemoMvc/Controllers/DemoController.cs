namespace DemoController.Controllers
{

    using Microsoft.AspNetCore.Mvc;

    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}