using Microsoft.AspNetCore.Mvc;

namespace PawCare.Controllers
{
    public class AppointmentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Book(string petName, string ownerName,
            string service, string appointmentDate, string vet)
        {
            ViewBag.Message = "Appointment booked successfully! 🐾";

            ViewBag.PetName = petName;
            ViewBag.Service = service;
            ViewBag.Date = appointmentDate;
            ViewBag.Vet = vet;

            return View("Index");
        }
    }
}