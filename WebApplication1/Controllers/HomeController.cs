using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        var cliente = new ClientePremiumViewModel
        {
            NomeCompleto = "Camila Lobato",
            DataNascimento = new DateTime(2000, 5, 10),
            Cpf = "123.456.789-00",
            TelefoneCelular = "(69) 99999-9999",
            UrlPerfilLinkedIn = "https://www.linkedin.com/in/camila",
            RendaMensal = 5000,
            NumeroCartaoCredito = "4111111111111111",
            SenhaAcesso = "Senha@123",
            ConfirmarSenhaAcesso = "Senha@123"
        };

        return View(cliente);
    }

    public IActionResult Privacy()
    {
        return View();
    }
}