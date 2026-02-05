using Microsoft.AspNetCore.Mvc;

namespace Clinic_Automation.Controllers
{
    public class PatientController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
