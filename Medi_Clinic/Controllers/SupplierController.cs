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
    [Authorize(Roles = "Supplier")]
    public class SupplierController : Controller
    {
        private readonly MediCureContext _context;
        public SupplierController(MediCureContext context)
        {
            _context = context;
        }
        // HttpContext.Session.SetString("LastVisited")
        public async Task<IActionResult> Index()
        {
            int supplierId = int.Parse(User.FindFirst("RoleReferenceId")!.Value);

            var supplier = _context.Suppliers
    .FirstOrDefault(p => p.SupplierId == supplierId);


            return View(supplier);
        }
    }
}

