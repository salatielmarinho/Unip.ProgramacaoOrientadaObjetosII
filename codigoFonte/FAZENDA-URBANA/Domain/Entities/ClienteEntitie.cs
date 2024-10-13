namespace Domain.Entities
{
    public class ClienteEntitie
    {
        public int Id { get; set; }
        public string NomeCliente { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public byte[] Senha { get; set; }
    }
}