using CpfCnpjLibrary;
using Desktop.ValidadoresComponentes;
using Domain.Entities;
using Repository.Configuration;
using Util.BD;
using Util.Controles;
using Util.Encrypt;

namespace Desktop
{
    public partial class frmIncluirCliente : Form
    {
        #region Propriedades
        private readonly SqlFactory _factory;
        private readonly Email _email;
        private readonly EncryptionHelper _encryptionHelper;
        private readonly ValidadorTextBox _validadorTextBox;
        private readonly Cliente _cliente;
        private readonly RepositoryConfiguration _configuration;

        #endregion

        #region Construtor
        public frmIncluirCliente(SqlFactory factory, RepositoryConfiguration configuration)
        {
            InitializeComponent();
            _factory = factory;
            _configuration = configuration;
            _email = new Email();
            _encryptionHelper = new EncryptionHelper();
            _validadorTextBox = new ValidadorTextBox();
            _cliente = new Cliente();
        }
        #endregion

        #region Eventos
        private void btnIncluirCliente_Click(object sender, EventArgs e)
        {
            bool retornoIncluirCliente = false;
            try
            {
                bool retornoValidarPreenchimentodeCampos = ValidarPreenchimentodeCampos();
                if (retornoValidarPreenchimentodeCampos)
                {
                    retornoIncluirCliente = _configuration.clienteRepository.IncluirCliente(_cliente);
                    if (retornoIncluirCliente)
                    {
                        MessageBox.Show("Cliente cadastrado com sucesso");
                        InicializarTela();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Você realmente deseja sair?", "Confirmação",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Close();
            }
        }
        #endregion

        #region Métodos
        private void InicializarTela()
        {
            try
            {
                txtNomeCliente.Clear();
                mskCpf.Clear();
                txtEmail.Clear();
                txtNomeCliente.Focus();
            }
            catch
            {
                throw;
            }
        }
        private bool ValidarPreenchimentodeCampos()
        {
            bool retornoValidarPreenchimentodeCampos = true;
            try
            {
                if (_validadorTextBox.ValidarTextBoxesPreenchidos(txtNomeCliente.Parent))
                {
                    _cliente.NomeCliente = txtNomeCliente.Text;
                }
                if (_validadorTextBox.ValidarTextBoxesPreenchidos(mskCpf.Parent))
                {
                    if (Cpf.Validar(mskCpf.Text))
                    {
                        _cliente.Cpf = mskCpf.Text;
                    }
                    else
                    {
                        MessageBox.Show("CPF inválido");
                        return false;
                    }
                }
                if (_validadorTextBox.ValidarTextBoxesPreenchidos(txtEmail.Parent))
                {
                    if (_email.ValidarEmail(txtEmail.Text))
                    {
                        _cliente.Email = txtEmail.Text;
                    }
                    else
                    {
                        MessageBox.Show("Email inválido");
                        return false;
                    }
                }
            }
            catch
            {
                throw;
            }
            return retornoValidarPreenchimentodeCampos;
        }
        #endregion        
    }
}