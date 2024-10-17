namespace API.Domain.Entities
{
    public class CursoEntity : BaseEntity
    {
        public CursoEntity(string nomeCurso, string descricao)
        {
            NomeCurso = nomeCurso;
            Descricao = descricao;
        }

        public string NomeCurso { get; set; }
        public string Descricao { get; set; }
    }
}