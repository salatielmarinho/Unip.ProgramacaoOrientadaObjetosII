using API.Domain.Entities;
using API.Infrastructure.Shared.Shared;

namespace API.Infrastructure.Input.Queries
{
    internal class AlunoQuery : BaseQuery
    {
        public QueryModel InsertAlunoQuery(AlunoEntity aluno)
        {
            this.Table = Map.GetAlunoTable();
            this.Query = $@"
            INSERT INTO {this.Table}
            VALUES
            (
                @NomeAluno,
                @DataNascimento,
                @CursoID               
            )
            ";

            this.Parameters = new
            {
                NomeAluno = aluno.NomeAluno,
                DataNascimento = aluno.DataNascimento,
                CursoID = (int)aluno.CursoId
            };

            return new QueryModel(this.Query, this.Parameters);
        }
    }
}