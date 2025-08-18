using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using GranStore.Models;

namespace GranStore.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        List<Categoria> categorias = [
            new() { Id = 1, Nome = "Notebook"},
            new() { Id = 2, Nome = "Celular"},
            new() { Id = 3, Nome = "Teclado"},
            new() { Id = 4, Nome = "Monitor"},
            new() { Id = 5, Nome = "Mouse"},
            new() { Id = 6, Nome = "Playstation"},
            

        ];

        List<Produto> produtos = [
            new() {
                Id = 1,
                Nome = "Notebook G15",
                QtdeEstoque = 5,
                ValorCusto = 2000m,
                ValorVenda = 5500m,
                Categoria = categorias[0],

            },
            new() {
                Id = 2,
                Nome = "Celular Xiaomi poco X7 Pro 5G",
                QtdeEstoque = 7,
                ValorCusto = 2180m,
                ValorVenda = 6000m,
                Categoria = categorias[1],

            },
        new() {
            Id = 3,
            Nome = "Teclado Mecânico Gamer",
            QtdeEstoque = 6,
            ValorCusto = 2000m,
            ValorVenda = 4000m,
            Categoria = categorias[2],
        },
        new() {
            Id = 4,
            Nome = "Monitor Dell de 24 - S2425H",
            QtdeEstoque = 9,
            ValorCusto = 2000m,
            ValorVenda = 5000m,
            Categoria = categorias[3],
        },
            new () {
                Id = 5,
                Nome = "Mouse",
                QtdeEstoque = 50,
                ValorCusto = 800,
                ValorVenda = 35,
                Categoria = categorias[4],

            },
            new () {
                Id = 
            }
        ];

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
