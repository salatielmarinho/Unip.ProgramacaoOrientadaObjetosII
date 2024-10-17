namespace Domain.Entities.Entities
{
    public class Curso
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Descricao { get; set; }
        public bool Status { get; set; }
        public DateTime DataCriacao { get; set; }
    }
}