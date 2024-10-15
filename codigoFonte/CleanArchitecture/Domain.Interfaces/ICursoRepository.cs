using Domain.Entities;

namespace Domain.Interfaces
{
    public interface ICursoRepository
    {
        bool AlterarCurso(Curso curso);
        List<Curso> ConsultaCursos();
        bool ExcluirCurso(int id);
        bool InserirCurso(Curso curso);
    }
}