using Applications.Configuration;
using Desktop.ValidadoresComponentes;
using Domain.DTO;
using Domain.Entities;
using Infrastructure.Encrypt;
using Infrastructure.Validadores;
using Newtonsoft.Json;
using System.Security.Cryptography;

namespace Presentation.ModuloUsuario
{
    public partial class frmIncluirUsuario : Form
    {
        #region Propriedades        
        private readonly Email _email;
        private readonly EncryptionHelper _encryptionHelper;
        private readonly ValidadorTextBox _validadorTextBox;
        private readonly Usuario _usuario;
        private readonly ServiceConfiguration _configuration;
        #endregion

        #region Construtor
        public frmIncluirUsuario(ServiceConfiguration configuration)
        {
            InitializeComponent();
            _email = new Email();
            _encryptionHelper = new EncryptionHelper();
            _validadorTextBox = new ValidadorTextBox();
            _usuario = new Usuario();
            _configuration = configuration;
            CarregarPefil();

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
                retornoIncluirUsuario = _configuration.usuarioService.IncluirUsuario(_usuario);
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
                    _usuario.Nome = txtNome.Text;
                }
                if (_validadorTextBox.ValidarTextBoxesPreenchidos(mskCep.Parent))
                {
                    _usuario.Cep = mskCep.Text;
                }
                if (_validadorTextBox.ValidarTextBoxesPreenchidos(txtEndereco.Parent))
                {
                    _usuario.Endereco = txtEndereco.Text;
                }
                if (_validadorTextBox.ValidarTextBoxesPreenchidos(txtComplemento.Parent))
                {
                    _usuario.Complemento = txtComplemento.Text;
                }
                if (_validadorTextBox.ValidarTextBoxesPreenchidos(txtNumero.Parent))
                {
                    _usuario.Numero = txtNumero.Text;
                }
                if (_validadorTextBox.ValidarTextBoxesPreenchidos(txtBairro.Parent))
                {
                    _usuario.Bairro = txtBairro.Text;
                }
                if (_validadorTextBox.ValidarTextBoxesPreenchidos(txtUF.Parent))
                {
                    _usuario.Uf = txtUF.Text;
                }
                if (_validadorTextBox.ValidarTextBoxesPreenchidos(txtEmail.Parent))
                {
                    if (_email.ValidarEmail(txtEmail.Text))
                    {
                        _usuario.Email = txtEmail.Text;
                    }
                    else
                    {
                        MessageBox.Show("Email inválido");
                    }
                }
                if (_validadorTextBox.ValidarTextBoxesPreenchidos(txtSenha.Parent))
                {
                    using (Aes myAes = Aes.Create())
                    {
                        byte[] senha = _encryptionHelper.EncryptStringToBytes_Aes(txtSenha.Text, myAes.Key, myAes.IV);
                        _usuario.Senha = senha;
                    }
                }
            }
            catch
            {
                throw;
            }
        }
        private void CarregarPefil()
        {
            cbxPerfil.DataSource = _configuration.perfilService.ConsultarTodosPerfis();
            cbxPerfil.DisplayMember = "NomePerfil";
            cbxPerfil.ValueMember = "Id";
        }
        #endregion              
    }
}