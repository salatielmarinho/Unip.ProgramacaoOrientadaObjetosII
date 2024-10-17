using API.Domain.Entities;

namespace API.Application.Input.Repositories
{
    public interface IWriteAlunoRepository
    {
        void InsertAluno(AlunoEntity aluno);
    }
}