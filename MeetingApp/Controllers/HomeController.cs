using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Controllers
{
    public class HomeController : Controller
    {
        // GET
        public string Index() 
        {
            return "Home/Index";
        }
    }    
}

