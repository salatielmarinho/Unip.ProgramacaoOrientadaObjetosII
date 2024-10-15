namespace Domain.Entities
{
    public class Aluno
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public DateOnly DataNascimento { get; set; }
        public int FkCurso { get; set; }
        public bool Status { get; set; }
        public DateTime DataCriacao { get; set; }
    }
}