using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ITGateway.Models;
using ITGateway.DATA;
using System.Security.Cryptography;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;
using System.Text;

namespace ITGateway.Controllers;

public class HomeController : Controller
{
    private readonly DataContext   _context;
         public HomeController(DataContext context)
        {
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

  public IActionResult Login(){

        return View();

    }

    [HttpGet("/Home/Login")]

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

// [HttpPost]
//         public ActionResult<string> addDevice(string devicetype)
//         {
//             var dev= new DevicesModel{
//                 device_name=devicetype,
//                 created_by="",
//                 created_at_utc=DateTime.UtcNow

//             };
            // if (device == null)
            // {
            //     return BadRequest("Device data is null.");
            // }

            
            // if (string.IsNullOrEmpty(device.created_by))
            // {
            //     return BadRequest("Created_by is required.");
            // }

            // _context.Device.Add(dev);
            // _context.SaveChanges();

            // return "";
    }




    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
    
