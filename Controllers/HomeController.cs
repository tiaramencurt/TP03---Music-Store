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
        ViewBag.discos = Info.listaDiscos;
        return View();
    }

    public IActionResult SelectDisco(int id)
    {
        Info.InicializarGrupo();
        if (Info.listaDiscos.ContainsKey(id))
        {
            ViewBag.disco = Info.listaDiscos[id];
            ViewBag.id = id;
        }
        return View ("InfoDiscos");
    }

}
