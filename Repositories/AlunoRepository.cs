using Academico.Models;
using Microsoft.AspNetCore.Routing.Constraints;
using Microsoft.EntityFrameworkCore;

namespace Academico.Repositories;

public class AlunoRepository : IAlunoRepository
{
    readonly AcademicoContext _context;

    public AlunoRepository(AcademicoContext context)
    {
        _context = context;
    }
    public async Task CriarAlunoAsync(Aluno aluno)
    {
        aluno.Cpf = new Random().Next(100000000, 999999999).ToString();
        aluno.Matricula = $"202609{new Random().Next(0, 99)}";
        await _context.AddAsync(aluno);
        await _context.SaveChangesAsync();
    }
}
public interface IAlunoRepository
{
    Task CriarAlunoAsync(Aluno aluno);
}