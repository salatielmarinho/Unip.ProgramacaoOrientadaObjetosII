using Repository.Configuration;
using Util.BD;

namespace Desktop.ModuloInicial
{
    public partial class frmLogin : Form
    {
        private readonly SqlFactory _factory;
        private readonly RepositoryConfiguration _configuration;

        public frmLogin(SqlFactory factory, RepositoryConfiguration configuration)
        {
            InitializeComponent();
            _factory = factory;
            _configuration = configuration;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            try
            {
                //implementar lógica

                this.Hide();
                frmMenu frmMenu = new frmMenu(_factory, _configuration);
                frmMenu.Closed += (s, args) => this.Close();
                frmMenu.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
    }
}
