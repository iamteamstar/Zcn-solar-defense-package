using Microsoft.AspNetCore.Mvc;

namespace ZCNGroup.Controllers
{
    public class SolarController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Details() { 
        return View();
        }
    }
}
