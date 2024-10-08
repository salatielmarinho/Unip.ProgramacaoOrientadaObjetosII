using API.Application.Input.Commands.AlunoContext;
using API.Application.Input.Receivers.Interfaces;
using API.Application.Input.Repositories;
using API.Domain.Entities;

namespace API.Application.Input.Receivers
{
    public class InsertAlunoReceiver : IReceiver<AlunoCommand, State>
    {
        private readonly IWriteAlunoRepository _repository;
        public InsertAlunoReceiver(IWriteAlunoRepository repository)
        {
            _repository = repository;
        }
        public State Action(AlunoCommand command)
        {
            var aluno = new AlunoEntity(command.NomeAluno, command.DataNascimento
            , command.CursoId);


            if (!aluno.IsValid())
                return new State(400, "Falha ao inserir verifique os campos", aluno.Notifications);

            try
            {
                _repository.InsertAluno(aluno);
                return new State(200, "Aluno(a) inserido(a) com sucesso", aluno);
            }
            catch (Exception ex)
            {
                return new State(500, ex.Message, null!);
            }

        }
    }
}
