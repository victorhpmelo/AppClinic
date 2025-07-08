using AppClinic.Data;
using AppClinic.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AppClinic.Controllers
{
    public class AppointmentController : Controller
    {
        private readonly ClinicContext _context;
        
        public AppointmentController(ClinicContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var appointments = _context.Appointments
                .Include(a => a.Patient)
                .ToList();
            return View(appointments);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Appointment appointment) 
        {
            _context.Appointments.Add(appointment);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
