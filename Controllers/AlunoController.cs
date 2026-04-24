using Academico.Models;
using Academico.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Academico.Controllers;

public class AlunoController : Controller
{
    readonly IAlunoRepository _alunoRepository;
    public AlunoController(IAlunoRepository alunoRepository)
    {
        _alunoRepository = alunoRepository;
    }
    public async Task<IActionResult> Index()
    {
      var aluno = await _alunoRepository.GetAlunoRepositoriesAsync();
      return View (aluno);
    }
    public IActionResult CriarAluno()
    {
        return View();
    }
    [HttpPost]
    public async Task<IActionResult> CriarAlunoAsync(Aluno aluno)
    {
        if(await _alunoRepository.CriarAlunoAsync(aluno))
        {
            TempData["Tipo"]= "Sucessso";
            TempData["Mensagem"] = $"Aluno {aluno.Nome} Cadastro com sucesso!";
        }
        else
        {
            TempData["Tipo"]= "Falha";
            TempData["Messagem"] = $"Aluno {aluno.Nome} não cadastrado!";
        }
        return RedirectToAction("CriarAluno");
    }
}