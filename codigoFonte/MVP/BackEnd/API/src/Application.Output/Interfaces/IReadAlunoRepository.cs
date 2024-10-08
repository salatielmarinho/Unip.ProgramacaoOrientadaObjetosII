using API.Application.Output.DTOs;

namespace API.Application.Output.Interfaces
{
    public interface IReadAlunoRepository
    {
        IEnumerable<AlunoDTO> GetAllAluno();
        AlunoDTO GetAlunoById(int id);
        IEnumerable<AlunoDTO> GetAlunoByCursoId(int cursoId);
    }
}