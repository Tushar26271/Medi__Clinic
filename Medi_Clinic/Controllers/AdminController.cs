using Microsoft.AspNetCore.Mvc;

namespace Medi_Clinic.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
