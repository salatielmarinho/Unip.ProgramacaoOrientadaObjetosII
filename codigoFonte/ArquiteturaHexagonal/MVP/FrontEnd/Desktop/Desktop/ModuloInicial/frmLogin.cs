using System.Security.Cryptography;
using Util;

namespace Desktop
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var encryptionHelper = new EncryptionHelper();
            try
            {
                using (Aes myAes = Aes.Create())
                {
                    byte[] encrypted = encryptionHelper.EncryptStringToBytes_Aes(txtSenha.Text, myAes.Key, myAes.IV);                    
                }

                this.Hide();
                frmMenu frmMenu = new frmMenu();
                frmMenu.Closed += (s, args) => this.Close();
                frmMenu.Show();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

    }
}