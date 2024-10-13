using Desktop.ValidadoresComponentes;
using Domain.DTO;
using Domain.Entities;
using Newtonsoft.Json;
using Repository.Interface;
using System.Security.Cryptography;
using Util.BD;
using Util.Controles;
using Util.Encrypt;

namespace Desktop.ModuloUsuario
{
    public partial class frmIncluirUsuario : Form
    {
        #region Propriedades
        private readonly SqlFactory _factory;
        private readonly Email _email;
        private readonly EncryptionHelper _encryptionHelper;
        private readonly ValidadorTextBox _validadorTextBox;
        private readonly UsuarioEntitie _usuarioEntitie;
        private readonly IUsuarioRepository _usuarioRepository;
        #endregion

        #region Construtor
        public frmIncluirUsuario(SqlFactory factory, IUsuarioRepository usuarioRepository)
        {
            InitializeComponent();
            _factory = factory;
            _email = new Email();
            _encryptionHelper = new EncryptionHelper();
            _validadorTextBox = new ValidadorTextBox();
            _usuarioEntitie = new UsuarioEntitie();
            _usuarioRepository = usuarioRepository;
        }
        #endregion

        #region Eventos
        private async void mskCep_Leave(object sender, EventArgs e)
        {
            string cep = mskCep.Text;
            string apiUrl = $"https://viacep.com.br/ws/{cep}/json/";
            string response = await GetApiData(apiUrl);
            var endereco = JsonConvert.DeserializeObject<EnderecoDTO>(response);
            txtEndereco.Text = endereco.Logradouro;
            txtBairro.Text = endereco.Bairro;
            txtUF.Text = endereco.Uf;
        }
        private void btnIncluirUsuario_Click(object sender, EventArgs e)
        {
            bool retornoIncluirUsuario = false;
            try
            {
                ValidarPreenchimentodeCampos();
                retornoIncluirUsuario = _usuarioRepository.IncluirUsuario(_usuarioEntitie);
                if (retornoIncluirUsuario)
                {
                    MessageBox.Show("Usuário cadastrado com sucesso");
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
        private async Task<string> GetApiData(string url)
        {
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();
                return await response.Content.ReadAsStringAsync();
            }
        }
        private void InicializarTela()
        {
            try
            {
                txtNome.Clear();
                mskCep.Clear();
                txtEndereco.Clear();
                txtComplemento.Clear();
                txtUF.Clear();
                txtBairro.Clear();
                txtNumero.Clear();
                txtEmail.Clear();
                txtSenha.Clear();
                txtNome.Focus();
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
                if (_validadorTextBox.ValidarTextBoxesPreenchidos(txtNome.Parent))
                {
                    _usuarioEntitie.Nome = txtNome.Text;
                }
                if (_validadorTextBox.ValidarTextBoxesPreenchidos(mskCep.Parent))
                {
                    _usuarioEntitie.Cep = mskCep.Text;
                }
                if (_validadorTextBox.ValidarTextBoxesPreenchidos(txtEndereco.Parent))
                {
                    _usuarioEntitie.Endereco = txtEndereco.Text;
                }
                if (_validadorTextBox.ValidarTextBoxesPreenchidos(txtComplemento.Parent))
                {
                    _usuarioEntitie.Complemento = txtComplemento.Text;
                }
                if (_validadorTextBox.ValidarTextBoxesPreenchidos(txtNumero.Parent))
                {
                    _usuarioEntitie.Numero = txtNumero.Text;
                }
                if (_validadorTextBox.ValidarTextBoxesPreenchidos(txtBairro.Parent))
                {
                    _usuarioEntitie.Bairro = txtBairro.Text;
                }
                if (_validadorTextBox.ValidarTextBoxesPreenchidos(txtUF.Parent))
                {
                    _usuarioEntitie.Uf = txtUF.Text;
                }
                if (_validadorTextBox.ValidarTextBoxesPreenchidos(txtEmail.Parent))
                {
                    if (_email.ValidarEmail(txtEmail.Text))
                    {
                        _usuarioEntitie.Email = txtEmail.Text;
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
                        _usuarioEntitie.Senha = senha;
                    }
                }
            }
            catch
            {
                throw;
            }
        }
        #endregion

        private void mskCep_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}