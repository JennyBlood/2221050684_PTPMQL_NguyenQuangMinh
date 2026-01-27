namespace DemoController.Controllers
{

    using Microsoft.AspNetCore.Mvc;

    public class DemoControllerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}