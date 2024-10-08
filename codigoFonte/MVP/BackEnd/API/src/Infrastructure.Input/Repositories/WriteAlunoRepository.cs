using Dapper;
using API.Application.Input.Repositories;
using API.Domain.Entities;
using API.Infrastructure.Input.Queries;
using API.Infrastructure.Shared.Factory;
using System.Data;

namespace API.Infrastructure.Input.Repositories
{
    public class WriteAlunoRepository : IWriteAlunoRepository
    {
        private readonly IDbConnection _connection;
        public WriteAlunoRepository(SqlFactory factory)
        {
            _connection = factory.SqlConnection();
        }
        public void InsertAluno(AlunoEntity aluno)
        {
            var query = new AlunoQuery().InsertAlunoQuery(aluno);

            try
            {
                using (_connection)
                {
                    _connection.Execute(query.Query, query.Parameters);
                }
            }
            catch
            {
                throw new Exception("Erro ao inserir aluno(a)");
            }
        }
    }
}