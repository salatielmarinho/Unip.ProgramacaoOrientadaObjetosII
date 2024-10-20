using Applications.Configuration;
using Presentation.ModuloCliente;
using Presentation.ModuloUsuario;

namespace Presentation.ModuloInicial
{
    public partial class frmMenu : Form
    {
        private readonly ServiceConfiguration _configuration;

        public frmMenu(ServiceConfiguration configuration)
        {
            InitializeComponent();
            _configuration = configuration;
        }

        private void gerenciarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmGerenciarCliente frmGerenciarCliente = new frmGerenciarCliente(_configuration);
                frmGerenciarCliente.MdiParent = this;
                frmGerenciarCliente.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void incluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmIncluirCliente frmIncluirCliente = new frmIncluirCliente(_configuration);
                frmIncluirCliente.MdiParent = this;
                frmIncluirCliente.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Você realmente deseja sair?", "Confirmação",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void incluirToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            try
            {
                frmIncluirUsuario frmIncluirUsuario = new frmIncluirUsuario(_configuration);
                frmIncluirUsuario.MdiParent = this;
                frmIncluirUsuario.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
    }
}