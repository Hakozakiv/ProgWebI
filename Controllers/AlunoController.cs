using Academico.Models;
using Microsoft.AspNetCore.Mvc;

namespace Academico.Controllers;

public class AlunoController : Controller
{
    public IActionResult Index()
    {
        List<Aluno> aluno1 = new List<Aluno>()
        {
            new Aluno ()
            {
                Nome = "Victor Hugo",
                Cpf = "123456789",
                Curso = "TADS",
                Matricula = "123654569852",
                DataNascimento = new DateOnly(1999, 07, 28)
            },
            new Aluno ()
            {
                Nome = "Leonardo",
                Cpf = "1256482262954",
                Curso = "TADS",
                Matricula ="485426295959",
                DataNascimento = new DateOnly(2000, 09, 12)
            }
        };
        return View(aluno1);
    }
}