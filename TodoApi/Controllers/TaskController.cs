using Microsoft.AspNetCore.Mvc;

namespace TodoApi.Controllers
{

    // ---------------------------------------
    // Similar to ProjectControllerClass
    // ---------------------------------------
    public class TaskController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
