using Applications.Configuration;
using Desktop.ValidadoresComponentes;
using Domain.Entities;

namespace Presentation.ModuloPerfil
{
    public partial class frmIncluirPerfil : Form
    {
        #region Propriedades        
        private readonly ValidadorTextBox _validadorTextBox;
        private readonly Perfil _Perfil;
        private readonly ServiceConfiguration _configuration;
        #endregion

        #region Construtor
        public frmIncluirPerfil(ServiceConfiguration configuration)
        {
            InitializeComponent();
            _validadorTextBox = new ValidadorTextBox();
            _Perfil = new Perfil();
            _configuration = configuration;
        }
        #endregion

        #region Eventos
        private void btnIncluirPerfil_Click(object sender, EventArgs e)
        {
            bool retornoIncluirPerfil = false;
            try
            {
                bool retornoValidarPreenchimentodeCampos = ValidarPreenchimentodeCampos();
                if (retornoValidarPreenchimentodeCampos)
                {
                    retornoIncluirPerfil = _configuration.perfilService.IncluirPerfil(_Perfil);
                    if (retornoIncluirPerfil)
                    {
                        MessageBox.Show("Perfil cadastrado com sucesso");
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
                txtNomePerfil.Clear();
                txtNomePerfil.Focus();
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
                if (_validadorTextBox.ValidarTextBoxesPreenchidos(txtNomePerfil.Parent))
                {
                    _Perfil.NomePerfil = txtNomePerfil.Text;
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