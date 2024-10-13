namespace Util.Validadores
{
    public class ValidadorTextBox
    {
        private void ValidarTextBoxesPreenchidos(Control parent)
        {
            try
            {
                foreach (Control control in parent.Controls)
                {
                    if (control is TextBox textBox)
                    {
                        if (string.IsNullOrWhiteSpace(textBox.Text))
                        {
                            MessageBox.Show($"O campo {textBox.Name} está vazio. Por favor, preencha-o.");                            
                        }
                    }
                }               
            }
            catch
            {
                throw;
            }
        }
    }
}