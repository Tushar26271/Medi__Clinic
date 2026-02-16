using Medi_Clinic.Models;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;


namespace Medi_Clinic.Controllers
{
    [Authorize(Roles = "Patient")]
    public class PatientController : Controller
    {
        private readonly MediCureContext _context;
        public PatientController(MediCureContext context)
        {
            _context = context;
        }
        // HttpContext.Session.SetString("LastVisited")
        public async Task<IActionResult> Index()
        {
            int patientId = int.Parse(User.FindFirst("RoleReferenceId")!.Value);

            var patient = _context.Patients
    .FirstOrDefault(p => p.PatientId == patientId);


            return View(patient);
        }
    }
}
