using AppClinic.Data;
using AppClinic.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AppClinic.Controllers
{
    public class PatientController : Controller
    {
        private readonly ClinicContext _context;

        public PatientController(ClinicContext context)
        {
            _context = context  ;
        }

        public async Task<IActionResult> Index()
        {
            var patients = await _context.Patient.ToListAsync();
            return View(patients);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PatientName,BirthDate,Paycheck")] Patient patient)
        {
            if (ModelState.IsValid)
            {
                _context.Patient.Add(patient);

                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));

            }
                return RedirectToAction(nameof(Index));
        }

        public IActionResult Edit()
        {
            return View();
        }
    }
}
