using Applications.Configuration;
using Domain.Entities;

namespace Presentation.ModuloPerfil
{
    public partial class frmGerenciarPerfil : Form
    {
        #region Propriedades
        private readonly Perfil _Perfil;
        private readonly ServiceConfiguration _configuration;
        #endregion

        #region Construtor
        public frmGerenciarPerfil(ServiceConfiguration configuration)
        {
            InitializeComponent();
            _Perfil = new Perfil();
            _configuration = configuration;
        }
        #endregion

        #region Eventos
        private void btnPesquisarPerfil_Click(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(txtFiltro.Text))
                {
                    dgPerfil.DataSource = _configuration.perfilService.ConsultarPerfil(txtFiltro.Text);
                    if (dgPerfil.RowCount == 0)
                    {
                        MessageBox.Show("Não existem registros para o Perfil informado.");
                    }
                }
                else
                {
                    MessageBox.Show("Preencher o filtro.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao pesquisar dados do Perfil: " + ex.Message);
            }
        }
        private void dgPerfil_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgPerfil.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dgPerfil.SelectedRows[0];
                    txtNome.Text = selectedRow.Cells["NomePerfil"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao selecionar dados do Perfil: " + ex.Message);
            }
        }
        private void btnAlterarPerfil_Click(object sender, EventArgs e)
        {
            bool PerfilAtualizado = false;
            try
            {
                if (dgPerfil.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dgPerfil.SelectedRows[0];
                    if (!String.IsNullOrEmpty(txtNome.Text))
                    {
                        _Perfil.NomePerfil = txtNome.Text;
                    }
                    else
                    {
                        MessageBox.Show("Preencher o campo Nome.");
                    }
                    _Perfil.Id = Convert.ToInt16(selectedRow.Cells["Id"].Value);
                    PerfilAtualizado = _configuration.perfilService.AlterarPerfil(_Perfil);
                    if (PerfilAtualizado)
                    {
                        MessageBox.Show("Dados do Perfil atualizados com sucesso.");
                        LimparTela();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar dados do Perfil: " + ex.Message);
            }
        }
        private void btnExcluirPerfil_Click(object sender, EventArgs e)
        {
            bool PerfilExcluido = false;
            try
            {
                if (dgPerfil.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dgPerfil.SelectedRows[0];
                    PerfilExcluido = _configuration.perfilService.ExcluirPerfil(Convert.ToInt16(selectedRow.Cells["Id"].Value));
                    if (PerfilExcluido)
                    {
                        MessageBox.Show("Dados do Perfil excluído com sucesso.");
                        LimparTela();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir dados do Perfil: " + ex.Message);
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
            dgPerfil.DataSource = null;
            txtFiltro.Clear();
            txtNome.Clear();
            txtFiltro.Focus();
        }
        #endregion
    }
}