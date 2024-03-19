using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MvcProducto.Models;

namespace MvcProducto.Controllers;

public class DemoController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public DemoController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        ViewBag.Message = "Hola mundo desde el controler";
        return View();
    }

    public IActionResult Index2()
    {
        ViewBag.Message = "Hola mundo desde el controler del metodo Index2";
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
