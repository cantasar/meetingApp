using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Controllers;

public class MeetingController : Controller
{
    // GET
    public string Index()
    {
        return "Meeting";
    }
}