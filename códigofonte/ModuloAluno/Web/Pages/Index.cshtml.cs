using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Web.Pages
{
    public class IndexModel : PageModel
    {
        public List<Aluno> Alunos { get; set; }

        public void OnGet()
        {
            Alunos = new List<Aluno>
        {
            new Aluno { Id = 1, Nome = "João", Idade = 25, Curso = "Redes", Email = "joao@unip.br", DataDeMatricula = DateTime.Now.Date, Endereco = "Rua Cachoeira, 1", Telefone = "1198765-8877" },
            new Aluno { Id = 2, Nome = "Maria", Idade = 18, Curso = "Gestão de TI", Email = "maria@unip.br", DataDeMatricula = DateTime.Now.Date, Endereco = "Rua Novo Estado, 5", Telefone = "1198667-8877" },
            new Aluno { Id = 3, Nome = "Pedro", Idade = 22, Curso = "Análise e Desenvolvimento de Sistemas", Email = "pedro@unip.br", DataDeMatricula = DateTime.Now.Date, Endereco = "Rua Santos de Almeida, 2", Telefone = "1198763-8877" }
        };
        }
    }

    public class Aluno
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Curso { get; set; }
        public string Email { get; set; }
        public DateTime DataDeMatricula { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
    }
}