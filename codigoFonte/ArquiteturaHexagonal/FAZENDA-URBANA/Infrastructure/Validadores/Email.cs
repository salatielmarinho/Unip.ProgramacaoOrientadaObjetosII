using System.Net.Mail;

namespace Infrastructure.Validadores
{
    public class Email
    {
        public bool ValidarEmail(string email)
        {
            try
            {
                var enderecoEmail = new MailAddress(email);
                return enderecoEmail.Address == email.Trim();
            }
            catch
            {
                return false;
            }
        }
    }
}