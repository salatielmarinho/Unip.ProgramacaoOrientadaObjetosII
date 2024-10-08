using API.Infrastructure.Shared.Shared;

namespace API.Infrastructure.Output.Queries
{
    internal class AlunoQueries : BaseQuery
    {
        public QueryModel GetAllAluno()
        {
            this.Table = Map.GetAlunoTable();
            this.InnerTable = Map.GetAlunoCursoTable();

            this.Query = $@"
            SELECT 
            V.[AlunoID],
            V.[NomeAluno],
            V.[DataNascimento],
            V.[CursoID],
            C.[NomeCurso],
            C.[Descricao]            
            FROM {this.Table} AS V 
            INNER JOIN {this.InnerTable} AS C 
            ON V.[CursoID] = C.[CursoID]
            ";

            return new QueryModel(this.Query, null!);
        }

        public QueryModel GetAlunoById(int alunoId)
        {
            this.Table = Map.GetAlunoTable();
            this.InnerTable = Map.GetAlunoCursoTable();

            this.Query = $@"
            SELECT 
            V.[AlunoID],
            V.[NomeAluno],
            V.[DataNascimento],
            C.[CursoID],
            C.[NomeCurso],
            C.[Descricao]            
            FROM {this.Table} AS V 
            INNER JOIN {this.InnerTable} AS C 
            ON v.[CursoID] = C.[CursoID]
            WHERE 
            V.AlunoID = @AlunoID
            ";
            this.Parameters = new
            {
                AlunoId = alunoId
            };

            return new QueryModel(this.Query, this.Parameters);
        }

        public QueryModel GetAlunoByCursoId(int cursoId)
        {
            this.Table = Map.GetAlunoTable();
            this.InnerTable = Map.GetAlunoCursoTable();

            this.Query = $@"
            SELECT 
            V.[AlunoID],
            V.[NomeAluno],
            V.[DataNascimento],
            C.[NomeCurso],
            C.[Descricao]            
            FROM {this.Table} AS V 
            INNER JOIN {this.InnerTable} AS C 
            ON v.[CursoID] = C.[CursoID]
            WHERE 
            V.CursoID = @CursoID
            ";
            this.Parameters = new
            {
                CursoId = cursoId
            };

            return new QueryModel(this.Query, this.Parameters);
        }
    }
}