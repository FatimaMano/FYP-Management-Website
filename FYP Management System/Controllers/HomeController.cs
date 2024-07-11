using System.Diagnostics;
using FYP_Management_System.Data;
using FYP_Management_System.Models;
using Microsoft.AspNetCore.Mvc;

namespace FYP_Management_System.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;


        public HomeController(ILogger<HomeController> logger,ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult ProjectIdeas()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SubmitProjectIdea(ProjectIdeas project)
        {
            if (ModelState.IsValid)
            {
                _context.ProjectIdeas.Add(project);
                _context.SaveChanges();
                return View("ProjectIdeaSubmitted", project);
            }
            return View("ProjectIdeas");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
