using Microsoft.AspNetCore.Mvc;

namespace Medi_Clinic.Controllers
{
    public class patient : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
