using Microsoft.AspNetCore.Mvc;

namespace la_mia_pizzeria_static
{
    public class EserciziController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
