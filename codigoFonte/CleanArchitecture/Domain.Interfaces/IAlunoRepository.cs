using Domain.Entities;

namespace Domain.Interfaces
{
    public interface IAlunoRepository
    {
        bool AlterarAluno(Aluno aluno);
        List<Aluno> ConsultarAluno();
        bool ExcluirAluno(int alunoId);
        bool InserirAluno(Aluno aluno);
    }
}