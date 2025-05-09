using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP03posta.Models;

namespace TP03posta.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        Info.InicializarGrupo();
        ViewBag.discos = Info.listaDiscos();
        return View();
    }
}
