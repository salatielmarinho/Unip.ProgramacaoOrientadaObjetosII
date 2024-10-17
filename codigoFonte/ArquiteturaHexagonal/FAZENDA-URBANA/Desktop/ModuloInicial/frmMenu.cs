using Desktop.ModuloCliente;
using Desktop.ModuloUsuario;
using Repository.Interface;
using Util.BD;

namespace Desktop.ModuloInicial
{
    public partial class frmMenu : Form
    {
        private readonly SqlFactory _factory;
        private readonly IClienteRepository _clienteRepository;
        private readonly IUsuarioRepository _usuarioRepository;
        public frmMenu(SqlFactory factory)
        {
            InitializeComponent();
            _factory = factory;
        }

        private void gerenciarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmGerenciarCliente frmGerenciarCliente = new frmGerenciarCliente(_factory, _clienteRepository);
                frmGerenciarCliente.MdiParent = this;
                frmGerenciarCliente.Show();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void incluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmIncluirCliente frmIncluirCliente = new frmIncluirCliente(_factory, _clienteRepository);
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
                    Application.Exit();
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
                frmIncluirUsuario frmIncluirUsuario = new frmIncluirUsuario(_factory, _usuarioRepository);
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