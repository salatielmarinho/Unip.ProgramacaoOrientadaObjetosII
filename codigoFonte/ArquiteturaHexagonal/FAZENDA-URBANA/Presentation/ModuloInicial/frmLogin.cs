using Applications.Configuration;
using Desktop.ValidadoresComponentes;
using Domain.Entities;
using Infrastructure.Encrypt;

namespace Presentation.ModuloInicial
{
    public partial class frmLogin : Form
    {
        #region Propriedades
        private readonly ServiceConfiguration _configuration;
        private readonly Usuario _usuario;
        private readonly PasswordHasher _passwordHasher;
        private readonly ValidadorTextBox _validadorTextBox;
        #endregion

        #region Construtor
        public frmLogin(ServiceConfiguration configuration)
        {
            InitializeComponent();
            _configuration = configuration;
            _usuario = new Usuario();
            _passwordHasher = new PasswordHasher();
            _validadorTextBox = new ValidadorTextBox();
        }
        #endregion

        #region Eventos
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
        private void ValidarPreenchimentodeCampos()
        {
            try
            {
                if (_validadorTextBox.ValidarTextBoxesPreenchidos(txtUsuario.Parent))
                {
                    _usuario.Nome = txtUsuario.Text;
                }
                if (_validadorTextBox.ValidarTextBoxesPreenchidos(txtSenha.Parent))
                {
                    _usuario.Senha = _passwordHasher.HashPassword(txtSenha.Text);
                }
            }
            catch
            {
                throw;
            }
        }
        #endregion
    }
}