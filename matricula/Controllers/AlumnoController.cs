using Microsoft.AspNetCore.Mvc;
using matricula.Models;
using matricula.Data;

namespace matricula.Controllers
{
    public class AlumnoController: Controller
    {
        private readonly AplicationDbContext _context;

        public AlumnoController(AplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create(Alumno objAlumno)
        {
            _context.Add(objAlumno);
            _context.SaveChanges();
            ViewData["Message"] = "Alumno registrado";
            return View("Index");
        }
    }
}