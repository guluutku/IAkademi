using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Ders56_ASP_NET_Core.Models;

namespace Ders56_ASP_NET_Core.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    IakademiContext iakademiContext = new IakademiContext();

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        List<Products> products = iakademiContext.Products.ToList();
        return View(products);
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

