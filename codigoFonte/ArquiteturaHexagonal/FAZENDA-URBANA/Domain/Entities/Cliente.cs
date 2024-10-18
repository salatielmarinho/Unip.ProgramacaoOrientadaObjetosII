namespace Domain.Entities
{
    public class Cliente
    {
        public int Id { get; set; }
        public string? NomeCliente { get; set; }
        public string? Cpf { get; set; }
        public string? Email { get; set; }
        public DateTime DataCriacao { get; set; }
    }
}