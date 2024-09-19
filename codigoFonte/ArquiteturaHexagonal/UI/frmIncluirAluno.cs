using Core;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace UI
{
    public partial class frmIncluirAluno : Form
    {
        private readonly IAlunoService _alunoService;

        #region Eventos

        public frmIncluirAluno(IAlunoService alunoService)
        {
            try
            {
                _alunoService = alunoService;
                InitializeComponent();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao inicializar form - frmIncluirAluno: " + ex.Message);
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            try
            {
                TextBox txtEmail = sender as TextBox;
                var validacaoEmail = ValidarEmail(txtEmail.Text);
                if (!validacaoEmail)
                {
                    MessageBox.Show("E-mail inválido");
                    txtEmail.Focus();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void mskTelefone_Leave(object sender, EventArgs e)
        {
            try
            {
                MaskedTextBox mskTelefone = sender as MaskedTextBox;
                var validacaoTelefone = ValidarTelefone(mskTelefone.Text);
                if (!validacaoTelefone)
                {
                    MessageBox.Show("Telefone inválido");
                    mskTelefone.Focus();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            ImpedirDigitacaoNumero(e);
        }

        private void txtIdade_KeyPress(object sender, KeyPressEventArgs e)
        {
            ImpedirLetrasCaracteresEspeciais(e);
        }

        private void frmIncluirAluno_Load(object sender, EventArgs e)
        {
            cbxCurso.SelectedIndex = 0;
        }

        private void btnIncluirAluno_Click(object sender, EventArgs e)
        {
            bool result = false;
            try
            {
                Aluno aluno = new Aluno();
                aluno.Nome = ValidarCampoObrigatorio(txtNome.Text);
                aluno.Idade = !String.IsNullOrEmpty(txtIdade.Text) ? Convert.ToInt16(txtIdade.Text) : 0;
                aluno.Curso = ValidarCampoObrigatorio(cbxCurso.Text);
                aluno.Email = ValidarCampoObrigatorio(txtEmail.Text);
                aluno.Endereco = ValidarCampoObrigatorio(txtEndereco.Text);
                aluno.Telefone = ValidarCampoObrigatorio(mskTelefone.Text);

                result = _alunoService.InserirAluno(aluno);

                if (result)
                {
                    MessageBox.Show("Aluno(a) Cadastrado(a) com Sucesso");
                    LimparCampos();
                }
                else
                {
                    MessageBox.Show("Não Foi Possível Cadastrar Aluno(a)");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar o aluno: " + ex.Message);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            // Configura a mensagem, título e botões do MessageBox
            string message = "Deseja realmente sair da aplicação?";
            string caption = "Sair";
            MessageBoxButtons buttons = MessageBoxButtons.YesNoCancel;
            DialogResult result;

            // Exibe o MessageBox e captura o resultado
            result = MessageBox.Show(message, caption, buttons);

            // Verifica qual botão foi clicado
            switch (result)
            {
                case DialogResult.Yes:
                    // Código para salvar as alterações
                    Close();
                    break;

                case DialogResult.No:
                    // Código para descartar as alterações
                    MessageBox.Show("Teste 1");
                    break;

                case DialogResult.Cancel:
                    // Código para cancelar a operação
                    MessageBox.Show("Teste 2.");
                    break;
            }
        }

        #endregion Eventos

        #region Métodos

        private void LimparCampos()
        {
            txtNome.Clear();
            txtIdade.Clear();
            cbxCurso.SelectedIndex = 0;
            txtEmail.Clear();
            txtEndereco.Clear();
            mskTelefone.Clear();
            txtNome.Focus();
        }

        private bool ValidarEmail(string email)
        {
            try
            {
                string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

                if (string.IsNullOrEmpty(email))
                {
                    return false;
                }

                Regex regex = new Regex(emailPattern);
                return regex.IsMatch(email);
            }
            catch (Exception)
            {
                throw;
            }
        }

        private bool ValidarTelefone(string telefone)
        {
            bool validacaoTelefone = false;
            try
            {
                string padraoTelefone = @"(\(?\d{2}\)?\s)?(\d{4,5}\-\d{4})";

                if (string.IsNullOrEmpty(telefone))
                {
                    return false;
                }

                Match resultado = Regex.Match(telefone, padraoTelefone);

                if (resultado.Success)
                {
                    validacaoTelefone = true;
                }
            }
            catch (Exception)
            {
                throw;
            }
            return validacaoTelefone;
        }

        private void ImpedirDigitacaoNumero(KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
            }
        }

        private void ImpedirLetrasCaracteresEspeciais(KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !Char.IsControl(e.KeyChar) && !(e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
            }
        }

        private string ValidarCampoObrigatorio(string texto)
        {
            try
            {
                if (String.IsNullOrEmpty(texto))
                {
                    MessageBox.Show("Campo Obrigatório");
                }
            }
            catch (Exception)
            {
                throw;
            }
            return texto;
        }

        #endregion Métodos        
    }
}