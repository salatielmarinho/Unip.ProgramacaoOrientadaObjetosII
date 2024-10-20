namespace Desktop.ValidadoresComponentes
{
    public class ValidadorTextBox
    {
        public bool ValidarTextBoxesPreenchidos(Control parent)
        {
            bool validadores = false;
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
                        else
                        {
                            validadores = true;
                        }
                    }
                }
                return validadores;
            }
            catch
            {
                throw;
            }
        }
    }
}