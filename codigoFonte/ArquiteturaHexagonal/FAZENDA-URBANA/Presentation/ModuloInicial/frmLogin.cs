using Applications.Configuration;
using Desktop.ValidadoresComponentes;
using Domain.Entities;
using Infrastructure.Encrypt;
using System.Security.Cryptography;

namespace Presentation.ModuloInicial
{
    public partial class frmLogin : Form
    {
        private readonly ServiceConfiguration _configuration;
        private readonly Usuario _usuario;
        private readonly EncryptionHelper _encryptionHelper;
        private readonly ValidadorTextBox _validadorTextBox;

        public frmLogin(ServiceConfiguration configuration)
        {
            InitializeComponent();
            _configuration = configuration;
            _usuario = new Usuario();
            _encryptionHelper = new EncryptionHelper();
            _validadorTextBox = new ValidadorTextBox();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            int fkPerfil = 0;
            try
            {
                ValidarPreenchimentodeCampos();
                fkPerfil = _configuration.usuarioService.ConsultarPerfilUsuario(_usuario);
                if (fkPerfil != 0)
                {
                    this.Hide();
                    frmMenu frmMenu = new frmMenu(_configuration, fkPerfil);
                    frmMenu.Closed += (s, args) => this.Close();
                    frmMenu.Show();
                }
                else
                {
                    MessageBox.Show("Usuário e/ou senha incorretos!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private bool ValidarPreenchimentodeCampos()
        {
            bool retornoValidarPreenchimentodeCampos = true;
            try
            {
                if (_validadorTextBox.ValidarTextBoxesPreenchidos(txtUsuario.Parent))
                {
                    _usuario.Nome = txtUsuario.Text;
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
            return retornoValidarPreenchimentodeCampos;
        }
    }
}