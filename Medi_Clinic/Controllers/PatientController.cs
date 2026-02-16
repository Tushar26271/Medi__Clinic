using Microsoft.AspNetCore.Mvc;
using ClinicManagementSystem.ViewModels;
using System.Linq;
using Medi_Clinic.Models;

namespace ClinicManagementSystem.Controllers
{

    public class PatientController : Controller
    {
        private readonly MediCureContext _context;

        public PatientController(MediCureContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        

            
        }
    }
}
