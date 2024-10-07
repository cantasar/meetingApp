using Microsoft.AspNetCore.Mvc;
using MeetingApp.Models;

namespace MeetingApp.Controllers;

public class MeetingController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Apply()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Apply(UserInfo model)
    {
        if (ModelState.IsValid)
        {
            Repository.AddUser(model);
            ViewBag.AttendeCount = Repository.Users.Where(i => i.WillAttend == true).Count();
            return View("Thanks", model);
        }
        return View(model);
    }

    public IActionResult List()
    {
        return View(Repository.Users);
    }

    public IActionResult Details(int id)
    {
        return View(Repository.GetById(id));
    }
}