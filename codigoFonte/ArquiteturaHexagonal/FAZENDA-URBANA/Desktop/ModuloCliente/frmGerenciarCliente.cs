using Domain.Entities;
using Repository.Interface;
using Util.BD;

namespace Desktop.ModuloCliente
{
    public partial class frmGerenciarCliente : Form
    {
        private readonly SqlFactory _factory;
        private readonly IClienteRepository _clienteRepository;
        private readonly ClienteEntitie _clienteEntitie;

        public frmGerenciarCliente(SqlFactory factory, IClienteRepository clienteRepository)
        {
            InitializeComponent();
            _factory = factory;
            _clienteRepository = clienteRepository;
            _clienteEntitie = new ClienteEntitie();
        }

        private void btnPesquisarCliente_Click(object sender, EventArgs e)
        {            
            try
            {
                if (!String.IsNullOrEmpty(txtFiltro.Text))
                {
                    dgCliente.DataSource = _clienteRepository.ConsultarCliente(txtFiltro.Text);
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
                        _clienteEntitie.NomeCliente = txtNome.Text;
                    }
                    else
                    {
                        MessageBox.Show("Preencher o campo Nome.");
                    }
                    _clienteEntitie.Id = Convert.ToInt16(selectedRow.Cells["Id"].Value);
                    clienteAtualizado = _clienteRepository.AlterarCliente(_clienteEntitie);
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

        private void LimparTela()
        {
            try
            {
                dgCliente.DataSource = null;
                txtFiltro.Clear();
                txtNome.Clear();
                txtFiltro.Focus();
            }
            catch
            {
                throw;
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
                    clienteExcluido = _clienteRepository.ExcluirCliente(Convert.ToInt16(selectedRow.Cells["Id"].Value));
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
    }
}