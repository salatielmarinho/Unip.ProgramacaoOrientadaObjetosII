namespace Domain.Entities
{
    public class UsuarioEntitie
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cep { get; set; }
        public string Endereco { get; set; }
        public string Complemento { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Uf { get; set; }
        public string Email { get; set; }
        public byte[] Senha { get; set; }
    }
}