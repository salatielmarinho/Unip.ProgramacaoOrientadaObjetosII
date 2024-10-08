using API.Application.Input.Commands.Interfaces;

namespace API.Application.Input.Commands.AlunoContext
{
    public class AlunoCommand : ICommand
    {
        public string NomeAluno { get; set; }
        public DateTime DataNascimento { get; set; }
        public int CursoId { get; set; }
    }
}