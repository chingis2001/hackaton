using hackaton.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace hackaton.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly hackatonContext _context;

        public HomeController(ILogger<HomeController> logger, hackatonContext context)
        {
            _context = context;
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<category> categories = _context.category.ToList();
            ViewBag.upper = categories.Where(t=>t.level==1).Select(t=>t.name);
            return View(categories);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
