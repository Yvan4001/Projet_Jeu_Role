using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Projet_Jeu_Role.Data;
using Projet_Jeu_Role.Models;
using System.Diagnostics;

namespace Projet_Jeu_Role.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger;
								private readonly ProjetMVCContext _context;

								public HomeController(ProjetMVCContext context)
								{
												_context = context;
								}

								public IActionResult Index()
        {
            return View();
        }

        public IActionResult Admin()
        {
            return View();
        }

        public IActionResult Player(Situation s)
        {
            s = _context.Situations.FirstOrDefault();
												return View(s);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}