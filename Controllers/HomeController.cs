using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ITGateway.Models;
using ITGateway.Data;
using Microsoft.EntityFrameworkCore;
namespace ITGateway.Controllers;

public class HomeController : Controller
{
        public DataContext _context ;
    
    public HomeController(DataContext context)
    {
            _context = context;
    }
    // public ActionResult BeforeLayoutContent()
    // {
    //     // Your logic here
    //     return PartialView("_BeforeLayoutContent");
    // }
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }
    public IActionResult Admin(){
        return View();
    }
     [HttpGet("/Home/Index")]
public ActionResult<string> UserLogin(string userName, string Password)
{
    if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(Password))
    {
        // Render the login form
        return View("Login");
    }

    var user = _context.UserInfo.SingleOrDefault(u => u.username == userName);
    if (user != null && Password==user.password)
    {
        return View("Admin");
    }
    return "Enter correct credentials";
}

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
