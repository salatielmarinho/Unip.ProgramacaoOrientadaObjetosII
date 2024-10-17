using Desktop.ValidadoresComponentes;
using Domain.Entities;
using Repository.Interface;
using System.Security.Cryptography;
using Util.BD;
using Util.Controles;
using Util.Encrypt;

namespace Desktop
{
    public partial class frmIncluirCliente : Form
    {
        #region Propriedades
        private readonly SqlFactory _factory;
        private readonly CPF _cpf;
        private readonly Email _email;
        private readonly EncryptionHelper _encryptionHelper;
        private readonly ValidadorTextBox _validadorTextBox;
        private readonly ClienteEntitie _clienteEntitie;
        private readonly IClienteRepository _clienteRepository;
        #endregion

        #region Construtor
        public frmIncluirCliente(SqlFactory factory, IClienteRepository clienteRepository)
        {
            InitializeComponent();
            _factory = factory;
            _cpf = new CPF();
            _email = new Email();
            _encryptionHelper = new EncryptionHelper();
            _validadorTextBox = new ValidadorTextBox();
            _clienteEntitie = new ClienteEntitie();
            _clienteRepository = clienteRepository;
        }
        #endregion

        #region Eventos
        private void btnIncluirCliente_Click(object sender, EventArgs e)
        {
            bool retornoIncluirCliente = false;
            try
            {
                ValidarPreenchimentodeCampos();
                retornoIncluirCliente = _clienteRepository.IncluirCliente(_clienteEntitie);
                if (retornoIncluirCliente)
                {
                    MessageBox.Show("Cliente cadastrado com sucesso");
                    InicializarTela();
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
                txtSenha.Clear();
                txtNomeCliente.Focus();
            }
            catch
            {
                throw;
            }
        }
        private void ValidarPreenchimentodeCampos()
        {
            try
            {
                if (_validadorTextBox.ValidarTextBoxesPreenchidos(txtNomeCliente.Parent))
                {
                    _clienteEntitie.NomeCliente = txtNomeCliente.Text;
                }
                if (_validadorTextBox.ValidarTextBoxesPreenchidos(mskCpf.Parent))
                {
                    if (_cpf.ValidarCPF(mskCpf.Text))
                    {
                        _clienteEntitie.Cpf = mskCpf.Text;
                    }
                    else
                    {
                        MessageBox.Show("CPF inválido");
                    }
                }
                if (_validadorTextBox.ValidarTextBoxesPreenchidos(txtEmail.Parent))
                {
                    if (_email.ValidarEmail(txtEmail.Text))
                    {
                        _clienteEntitie.Email = txtEmail.Text;
                    }
                    else
                    {
                        MessageBox.Show("Email inválido");
                    }
                }
                if (_validadorTextBox.ValidarTextBoxesPreenchidos(txtSenha.Parent))
                {
                    // Cria uma nova instância da classe Aes.
                    using (Aes myAes = Aes.Create())
                    {
                        byte[] senha = _encryptionHelper.EncryptStringToBytes_Aes(txtEmail.Text, myAes.Key, myAes.IV);
                        _clienteEntitie.Senha = senha;
                    }
                }
            }
            catch
            {
                throw;
            }
        }
        #endregion

        private void mskCpf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}