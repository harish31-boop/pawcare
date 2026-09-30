using Microsoft.AspNetCore.Mvc;

namespace PawCare.Controllers
{
    public class HealthCheckupController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}