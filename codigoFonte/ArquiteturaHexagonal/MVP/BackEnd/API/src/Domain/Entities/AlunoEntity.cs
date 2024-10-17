using API.Domain.Notifications;
using API.Domain.Validations;
using API.Domain.Validations.Interfaces;

namespace API.Domain.Entities
{
    public class AlunoEntity : BaseEntity, IValidate
    {
        #region Internal Props
        List<Notification> _notifications;
        #endregion

        public AlunoEntity(string nomeAluno, DateTime dataNascimento, int cursoId)
        {
            NomeAluno = nomeAluno;
            DataNascimento = dataNascimento;
            CursoId = cursoId;
            _notifications = new List<Notification>();
            IsValid();
        }

        #region  External Props
        public string NomeAluno { get; private set; }
        public DateTime DataNascimento { get; set; }
        public int CursoId { get; private set; }
        public IReadOnlyCollection<Notification> Notifications => _notifications;

        #endregion

        // Validations
        public bool IsValid()
        {
            return
                new AlunoValidations(this).MinNameLength().MaxNameLength().IsValid();
        }

        // Notifications
        public void PullNotification(Notification notification)
        {
            this._notifications.Add(notification);
        }
    }
}