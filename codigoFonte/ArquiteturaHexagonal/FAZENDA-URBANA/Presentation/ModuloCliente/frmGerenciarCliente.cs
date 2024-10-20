using Applications.Configuration;
using Domain.Entities;

namespace Presentation.ModuloCliente
{
    public partial class frmGerenciarCliente : Form
    {
        #region Propriedades
        private readonly Cliente _cliente;
        private readonly ServiceConfiguration _configuration;
        #endregion

        #region Construtor
        public frmGerenciarCliente(ServiceConfiguration configuration)
        {
            InitializeComponent();
            _cliente = new Cliente();
            _configuration = configuration;
        }
        #endregion

        #region Eventos
        private void btnPesquisarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(txtFiltro.Text))
                {
                    dgCliente.DataSource = _configuration.clienteService.ConsultarCliente(txtFiltro.Text);
                    if (dgCliente.RowCount == 0)
                    {
                        MessageBox.Show("Não existem registros para o cliente informado.");
                    }
                }
                else
                {
                    MessageBox.Show("Preencher o filtro.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao pesquisar dados do cliente: " + ex.Message);
            }
        }
        private void dgCliente_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgCliente.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dgCliente.SelectedRows[0];
                    txtNome.Text = selectedRow.Cells["NomeCliente"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao selecionar dados do cliente: " + ex.Message);
            }
        }
        private void btnAlterarCliente_Click(object sender, EventArgs e)
        {
            bool clienteAtualizado = false;
            try
            {
                if (dgCliente.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dgCliente.SelectedRows[0];
                    if (!String.IsNullOrEmpty(txtNome.Text))
                    {
                        _cliente.NomeCliente = txtNome.Text;
                    }
                    else
                    {
                        MessageBox.Show("Preencher o campo Nome.");
                    }
                    _cliente.Id = Convert.ToInt16(selectedRow.Cells["Id"].Value);
                    clienteAtualizado = _configuration.clienteService.AlterarCliente(_cliente);
                    if (clienteAtualizado)
                    {
                        MessageBox.Show("Dados do cliente atualizados com sucesso.");
                        LimparTela();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar dados do cliente: " + ex.Message);
            }
        }
        private void btnExcluirCliente_Click(object sender, EventArgs e)
        {
            bool clienteExcluido = false;
            try
            {
                if (dgCliente.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dgCliente.SelectedRows[0];
                    clienteExcluido = _configuration.clienteService.ExcluirCliente(Convert.ToInt16(selectedRow.Cells["Id"].Value));
                    if (clienteExcluido)
                    {
                        MessageBox.Show("Dados do cliente excluído com sucesso.");
                        LimparTela();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir dados do cliente: " + ex.Message);
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
            dgCliente.DataSource = null;
            txtFiltro.Clear();
            txtNome.Clear();
            txtFiltro.Focus();
        }
        #endregion
    }
}