namespace Desktop
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void incluirAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIncluirAluno frmIncluirAluno = new frmIncluirAluno();
            frmIncluirAluno.MdiParent = this;
            frmIncluirAluno.Show();
        }

        private void gerenciarAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGerenciarAluno frmGerenciarAluno = new frmGerenciarAluno();
            frmGerenciarAluno.MdiParent = this;
            frmGerenciarAluno.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Você realmente deseja sair?", "Confirmação", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
