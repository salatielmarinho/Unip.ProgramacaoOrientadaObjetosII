using System.Net.Mail;

namespace Util.Controles
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