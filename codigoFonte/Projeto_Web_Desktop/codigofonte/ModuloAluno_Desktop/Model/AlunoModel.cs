using System;

namespace Model
{
    public class AlunoModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Curso { get; set; }
        public string Email { get; set; }
        public DateTime DataDeMatricula { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public string ConnectionStrings { get; set; }

    }
}