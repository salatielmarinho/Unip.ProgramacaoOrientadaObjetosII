using Applications.Configuration;

namespace Presentation.ModuloInicial
{
    public partial class frmLogin : Form
    {
        private readonly ServiceConfiguration _configuration;

        public frmLogin(ServiceConfiguration configuration)
        {
            InitializeComponent();
            _configuration = configuration;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            try
            {
                //implementar lógica

                this.Hide();
                frmMenu frmMenu = new frmMenu(_configuration);
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
