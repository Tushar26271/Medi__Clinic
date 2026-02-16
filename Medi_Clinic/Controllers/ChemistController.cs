using Medi_Clinic.Models;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Medi_Clinic.Controllers
{
    [Authorize(Roles = "Chemist")]
    public class ChemistController : Controller
    {
        private readonly MediCureContext _context;
        public ChemistController(MediCureContext context)
        {
            _context = context;
        }
        // HttpContext.Session.SetString("LastVisited")
        public async Task<IActionResult> Index()
        {
            int chemistId = int.Parse(User.FindFirst("RoleReferenceId")!.Value);

            var chemist = _context.Chemists
    .FirstOrDefault(p => p.ChemistId == chemistId);


            return View(chemist);
        }
    }
}
