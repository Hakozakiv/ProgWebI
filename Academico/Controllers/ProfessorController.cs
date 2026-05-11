using Microsoft.AspNetCore.Mvc;
using Academico.Models;
using Academico.Repositories;

namespace Academico.Controllers;

public class ProfessorController : Controller
{
    readonly IProfessorRepository _professorRepository;

    public ProfessorController(IProfessorRepository professorRepository)
    {
        _professorRepository = professorRepository;
    }

    public IActionResult CriarProfessor()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> CriarProfessorAsync(Professor professor)
    {
        if(await _professorRepository.CriarProfessorAsync(professor))
        {
            TempData["Tipo"]= "sucesso";
            TempData["Mensagem"] = $"Aluno {professor.Nome} Cadastro com sucesso!";
        }
        else
        {
            TempData["Tipo"]= "falha";
            TempData["Messagem"] = $"Aluno {professor.Nome} não cadastrado!";
        }
        return RedirectToAction("CriarProfessor");
    }
}
