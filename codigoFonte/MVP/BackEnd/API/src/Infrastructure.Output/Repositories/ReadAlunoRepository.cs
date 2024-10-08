using Dapper;
using API.Application.Output.DTOs;
using API.Application.Output.Interfaces;
using API.Infrastructure.Output.Queries;
using API.Infrastructure.Shared.Factory;
using System.Data;

namespace API.Infrastructure.Output.Repositories
{
    public class ReadAlunoRepository : IReadAlunoRepository
    {
        private readonly IDbConnection _connection;
        public ReadAlunoRepository(SqlFactory factory)
        {
            _connection = factory.SqlConnection();
        }
        public IEnumerable<AlunoDTO> GetAllAluno()
        {
            var query = new AlunoQueries().GetAllAluno();
            try
            {
                using (_connection)
                {
                    return _connection.Query<AlunoDTO>(query.Query) as List<AlunoDTO>;
                }
            }
            catch
            {
                throw new Exception("Falha ao recuperar alunos(as)");
            }
        }
        public IEnumerable<AlunoDTO> GetAlunoByCursoId(int cursoId)
        {
            var query = new AlunoQueries().GetAlunoByCursoId(cursoId);
            try
            {
                using (_connection)
                {
                    return _connection.Query<AlunoDTO>(query.Query, query.Parameters) as List<AlunoDTO>;
                }
            }
            catch
            {
                throw new Exception("Falha ao recuperar alunos(as)");
            }
        }
        public AlunoDTO GetAlunoById(int id)
        {
            var query = new AlunoQueries().GetAlunoById(id);
            try
            {
                using (_connection)
                {
                    var result = _connection.QueryFirstOrDefault<AlunoDTO>(query.Query, query.Parameters) as AlunoDTO;
                    if(result is null)
                    {
                        AlunoDTO alunoDTO = new AlunoDTO();
                        alunoDTO.Mensagem = "Não existe registro cadastrado na tabela Aluno para o código informado";
                        result = alunoDTO;
                    }
                    return result;
                }                
            }
            catch
            {
                throw;
            }
        }        
    }
}