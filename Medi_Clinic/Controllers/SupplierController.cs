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
        public IActionResult Index()
        {
            return View();
        }
    }
}

