using ClinicManagementSystem.ViewModels;
using Medi_Clinic.Models;
using Microsoft.AspNetCore.Mvc;

public class PatientController : Controller
{
    private readonly MediCureContext _context;

    public PatientController(MediCureContext context)
    {
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
    }
}
