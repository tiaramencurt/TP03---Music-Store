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
        //Consigna: Debe recibir el dni de un alumno que desea ver. Luego traer la info de los integrantes del diccionario y buscar el dni recibido.
        /*Cargar la información requerida del integrante correspondiente en un ViewBag.
        Cargar el DNI en otro ViewBag
        Retornar la vista infoDatosPersonales.
        */
        Info.InicializarGrupo();
        if (Info.listaDiscos.ContainsKey(id))
        {
            ViewBag.disco = Info.listaDiscos[id].disco;
            ViewBag.DNI = DNI;
        }
       
        return View ("InfoDatosPersonales");

    }

}
