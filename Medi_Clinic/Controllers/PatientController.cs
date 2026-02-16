<<<<<<< HEAD
﻿using ClinicManagementSystem.ViewModels;
using Medi_Clinic.Models;
using Microsoft.AspNetCore.Mvc;
=======
﻿using Medi_Clinic.Models;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
>>>>>>> 091369cdc7bdbf7b1644d94a099dd40c11a03096

public class PatientController : Controller
{
    private readonly MediCureContext _context;

    public PatientController(MediCureContext context)
    {
<<<<<<< HEAD
        _context = context;
    }

    // NEW METHOD (paste this)
    public IActionResult Index()
    {
        var firstPatient = _context.Patients.FirstOrDefault();

        if (firstPatient == null)
            return Content("No patients in database!");

        return RedirectToAction("Index", new { id = firstPatient.PatientId });
    }

    // EXISTING METHOD
    public IActionResult Index(int id)
    {
        var patient = _context.Patients.FirstOrDefault(p => p.PatientId == id);

        var viewModel = new PatientDashboardViewModel
        {
            Patient = patient,
            Appointments = _context.Appointments.Where(a => a.PatientId == id).ToList(),
        };

        return View(viewModel);
=======
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
>>>>>>> 091369cdc7bdbf7b1644d94a099dd40c11a03096
    }
}
