namespace Domain.Entities
{
    public class Perfil
    {
        public int Id { get; set; }
        public string? NomePerfil { get; set; }
        public bool Ativo { get; set; }
        public DateTime DataCriacao { get; set; }
    }
}