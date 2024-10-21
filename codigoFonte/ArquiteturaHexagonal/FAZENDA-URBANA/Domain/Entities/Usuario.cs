namespace Domain.Entities
{
    public class Usuario
    {
        public int Id { get; set; }
        public int Fk_Perfil { get; set; }
        public string NomePerfil { get; set; }
        public string Nome { get; set; }
        public string Cep { get; set; }
        public string Endereco { get; set; }
        public string Complemento { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Uf { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public DateTime DataCriacao { get; set; }
    }
}