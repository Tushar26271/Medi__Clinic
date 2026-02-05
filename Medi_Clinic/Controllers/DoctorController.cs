using Microsoft.AspNetCore.Mvc;

namespace Clinic_Automation.Controllers
{
    public class DoctorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
