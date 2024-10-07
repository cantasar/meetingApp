using MeetingApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Controllers
{
    public class HomeController : Controller
    {
        // GET
        public IActionResult Index(Repository repository)
        {
            return View(model: repository);
        }
    }    
}

