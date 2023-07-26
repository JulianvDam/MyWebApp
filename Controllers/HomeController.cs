using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MyWebApp.Models;

namespace MyWebApp.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
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

    [HttpPost]
    public JsonResult SendEmail(string name, string email, string message)
    {
        try
        {
            Message mailMessage = new Message(name, email, message);
            mailMessage.SendEmail();

            return Json(new { status = "success", message = "Form submitted successfully!" });
        }
        catch (Exception ex)
        {
            return Json(new { status = "error", message = ex.Message });
        }
    }
}
