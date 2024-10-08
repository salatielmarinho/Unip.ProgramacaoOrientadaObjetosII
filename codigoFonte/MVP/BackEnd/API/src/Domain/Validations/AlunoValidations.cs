using API.Domain.Entities;
using API.Domain.Notifications;
using API.Domain.Validations.Interfaces;

namespace API.Domain.Validations
{
    internal class AlunoValidations : IValidate
    {
        private readonly AlunoEntity _aluno;
        public AlunoValidations(AlunoEntity aluno)
        {
            this._aluno = aluno;
        }

        public AlunoValidations MinNameLength()
        {
            if (_aluno.NomeAluno.Length < 5)
                _aluno.PullNotification(
                    new Notification(
                        "NomeAluno", "O nome deve conter um mínimo de 5 caracteres"));

            return this;
        }

        public AlunoValidations MaxNameLength()
        {
            if (_aluno.NomeAluno.Length > 20)
                _aluno.PullNotification(
                    new Notification(
                        "Name", "Quantidade máxima de caracteres ultrapassada"));

            return this;
        }

        public bool IsValid()
        {
            return (_aluno.Notifications.Count == 0 ? true : false);
        }
    }
}