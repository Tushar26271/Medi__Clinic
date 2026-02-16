
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
    [Authorize(Roles = "Physician")]
    public class PhysicianController : Controller
    {
        private readonly MediCureContext _context;
        public PhysicianController(MediCureContext context)
        {
            _context = context;
        }
        // HttpContext.Session.SetString("LastVisited")
        public async Task<IActionResult> Index()
        {
            int physicianId = int.Parse(User.FindFirst("RoleReferenceId")!.Value);

            var physician = _context.Physicians
    .FirstOrDefault(p => p.PhysicianId == physicianId);


            return View(physician);
        }
    }
}
