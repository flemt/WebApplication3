using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication3.Models;


namespace WebApplication3.Controllers
{
    public class KontaktController : Controller
    {

        public IActionResult Index()
        {
         
            return View();
        }
 
     


        private readonly ILogger<KontaktController> _logger;

        public KontaktController(ILogger<KontaktController> logger)
        {
            _logger = logger;
        }

      

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}