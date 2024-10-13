using Util.BD; 

namespace Desktop.ModuloInicial
{
    public partial class frmLogin : Form
    {
        private readonly SqlFactory _factory;
        public frmLogin(SqlFactory factory)
        {
            InitializeComponent();
            _factory = factory;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            try
            {
                //implementar lógica

                this.Hide();
                frmMenu frmMenu = new frmMenu(_factory);
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
