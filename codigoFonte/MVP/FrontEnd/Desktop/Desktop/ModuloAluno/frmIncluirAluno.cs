using Model;
using Newtonsoft.Json;

namespace Desktop
{
    public partial class frmIncluirAluno : Form
    {
        #region Eventos
        public frmIncluirAluno()
        {
            InitializeComponent();
        }
        private async void btnIncluirAluno_Click(object sender, EventArgs e)
        {
           
        }            

        private async void mskCEP_Leave(object sender, EventArgs e)
        {
            string cep = mskCEP.Text;
            string apiUrl = $"https://viacep.com.br/ws/{cep}/json/";
            string response = await GetApiData(apiUrl);
            var endereco = JsonConvert.DeserializeObject<Endereco>(response);
            txtBairro.Text = endereco.Bairro;
            txtEndereco.Text = endereco.Logradouro;
        }
        #endregion

        #region Métodos
        private async Task<string> GetApiData(string url)
        {
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();
                return await response.Content.ReadAsStringAsync();
            }
        }
        #endregion
    }
}