using CheckpointVModelBinding.Models;
using Microsoft.AspNetCore.Mvc;

namespace CheckpointVModelBinding.Controllers;

public class AlunoController : Controller
{
    [HttpGet]
    public IActionResult Cadastrar()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Cadastrar(Aluno aluno)
    {
        if (!ModelState.IsValid)
        {
            return View(aluno);
        }

        return View("Confirmacao", aluno);
    }
}
