using Applications.Configuration;
using Domain.Entities;

namespace Presentation.ModuloUsuario
{
    public partial class frmGerenciarUsuario : Form
    {
        #region Propriedades
        private readonly Usuario _Usuario;
        private readonly ServiceConfiguration _configuration;
        #endregion

        #region Construtor
        public frmGerenciarUsuario(ServiceConfiguration configuration)
        {
            InitializeComponent();
            _Usuario = new Usuario();
            _configuration = configuration;
        }
        #endregion

        #region Eventos
        private void btnPesquisarUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(txtFiltro.Text))
                {
                    dgUsuario.DataSource = _configuration.usuarioService.ConsultarUsuario(txtFiltro.Text);
                    if (dgUsuario.RowCount == 0)
                    {
                        MessageBox.Show("Não existem registros para o Usuario informado.");
                    }
                }
                else
                {
                    MessageBox.Show("Preencher o filtro.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao pesquisar dados do Usuario: " + ex.Message);
            }
        }
        private void dgUsuario_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgUsuario.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dgUsuario.SelectedRows[0];
                    txtNome.Text = selectedRow.Cells["NomeUsuario"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao selecionar dados do Usuario: " + ex.Message);
            }
        }
        private void btnAlterarUsuario_Click(object sender, EventArgs e)
        {
            bool UsuarioAtualizado = false;
            try
            {
                if (dgUsuario.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dgUsuario.SelectedRows[0];
                    if (!String.IsNullOrEmpty(txtNome.Text))
                    {
                        _Usuario.Nome = txtNome.Text;
                    }
                    else
                    {
                        MessageBox.Show("Preencher o campo Nome.");
                    }
                    _Usuario.Id = Convert.ToInt16(selectedRow.Cells["Id"].Value);
                    UsuarioAtualizado = _configuration.usuarioService.AlterarUsuario(_Usuario);
                    if (UsuarioAtualizado)
                    {
                        MessageBox.Show("Dados do Usuario atualizados com sucesso.");
                        LimparTela();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar dados do Usuario: " + ex.Message);
            }
        }
        private void btnExcluirUsuario_Click(object sender, EventArgs e)
        {
            bool UsuarioExcluido = false;
            try
            {
                if (dgUsuario.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dgUsuario.SelectedRows[0];
                    UsuarioExcluido = _configuration.usuarioService.ExcluirUsuario(Convert.ToInt16(selectedRow.Cells["Id"].Value));
                    if (UsuarioExcluido)
                    {
                        MessageBox.Show("Dados do Usuario excluído com sucesso.");
                        LimparTela();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir dados do Usuario: " + ex.Message);
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
        private void LimparTela()
        {
            dgUsuario.DataSource = null;
            txtFiltro.Clear();
            txtNome.Clear();
            txtFiltro.Focus();
        }
        #endregion
    }
}