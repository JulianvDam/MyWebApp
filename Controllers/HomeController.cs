using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MyWebApp.Models;

namespace MyWebApp.Controllers;

public class HomeController : Controller
{
    private readonly IEmailSender _emailSender;
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger, IEmailSender emailSender)
    {
        this._emailSender = emailSender;
        _logger = logger;
    }

    public async Task<IActionResult> Index()
    {
        var name = "a";
        var emailFrom = "julianvdam@outlook.com";
        var message = "TEST";

        //await _emailSender.SendEmail(name, emailFrom, message);
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
}
