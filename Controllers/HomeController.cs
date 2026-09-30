using Microsoft.AspNetCore.Mvc;
using PawCare.Models;
using System.Diagnostics;

namespace PawCare.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult HealthCheckup()
        {
            return View();
        }

        public IActionResult PetMedicines()
        {
            return View();
        }

        public IActionResult VeterinaryConsultation()
        {
            return View();
        }

        public IActionResult EmergencyCare()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel
            {
                RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier
            });
        }
    }
}