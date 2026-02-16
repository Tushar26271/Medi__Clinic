using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Medi_Clinic.Models;
using Microsoft.AspNetCore.Authorization;


namespace Medi_Clinic.Controllers
{
    [Authorize(Roles = "Patient")]
    public class PatientController : Controller
    {
       // HttpContext.Session.SetString("LastVisited")
        public IActionResult Index()
        {
            return View();
        }
    }
}
