namespace API.Application.Output.DTOs
{
    public class AlunoDTO : CursoDTO
    {
        public int AlunoId { get; set; }
        public string NomeAluno { get; set; }
        public DateTime DataNascimento { get; set; }
        public int CursoId { get; set; }
        public string Mensagem { get; set; }
    }
}