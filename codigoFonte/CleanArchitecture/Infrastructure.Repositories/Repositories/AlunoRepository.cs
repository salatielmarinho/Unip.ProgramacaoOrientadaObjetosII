using Domain.Entities.Entities;
using Domain.Interfaces;
using Infrastructure.Data.Factory;
using Microsoft.Data.SqlClient;
using System.Data;

namespace Infrastructure.Repositories.Repositories
{
    public class AlunoRepository : IAlunoRepository
    {
        private readonly IDbConnection _connection;
        public AlunoRepository(SqlFactory factory)
        {
            _connection = factory.SqlConnection();
        }
        public bool AlterarAluno(Aluno aluno)
        {
            bool alterarAluno = false;
            try
            {
                _connection.Open();
                using (SqlCommand command = new SqlCommand("AlterarAluno", (SqlConnection)_connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@Id", aluno.Id);
                    command.Parameters.AddWithValue("@Nome", aluno.Nome);
                    command.Parameters.AddWithValue("@DataNascimento", aluno.DataNascimento);
                    command.Parameters.AddWithValue("@Status", aluno.Status);

                    if (command.ExecuteNonQuery() > 0)
                    {
                        alterarAluno = true;
                    }
                }
            }
            catch
            {
                throw;
            }
            finally
            {
                _connection.Close();
            }
            return alterarAluno;
        }
        public List<Aluno> ConsultarAluno()
        {
            List<Aluno> lstAlunos = new List<Aluno>();
            try
            {
                _connection.Open();
                using (SqlCommand command = new SqlCommand("ConsultarAluno", (SqlConnection)_connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Aluno aluno = new Aluno
                            {
                                Id = (int)reader["AlunoID"],
                                Nome = reader["NomeAluno"].ToString(),
                                DataNascimento = (DateOnly)reader["DataNascimento"],
                                FkCurso = (int)reader["CursoID"],
                                Status = (bool)reader["Status"]
                            };
                            lstAlunos.Add(aluno);
                        }
                    }
                }
            }
            catch
            {
                throw;
            }
            finally
            {
                _connection.Close();
            }
            return lstAlunos;
        }
        public bool ExcluirAluno(int id)
        {
            bool excluirCliente = false;
            try
            {
                _connection.Open();
                using (SqlCommand command = new SqlCommand("ExcluirAluno", (SqlConnection)_connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@Id", id);

                    if (command.ExecuteNonQuery() > 0)
                    {
                        excluirCliente = true;
                    }
                }
            }
            catch
            {
                throw;
            }
            finally
            {
                _connection.Close();
            }
            return excluirCliente;
        }
        public bool InserirAluno(Aluno aluno)
        {
            bool inserirAluno = false;
            try
            {
                _connection.Open();
                using (SqlCommand command = new SqlCommand("InserirCliente", (SqlConnection)_connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@Nome", aluno.Nome);
                    command.Parameters.AddWithValue("@DataNascimento", aluno.DataNascimento);
                    command.Parameters.AddWithValue("@FKCurso", aluno.FkCurso);

                    if (command.ExecuteNonQuery() > 0)
                    {
                        inserirAluno = true;
                    }
                }
            }
            catch
            {
                throw;
            }
            finally
            {
                _connection.Close();
            }
            return inserirAluno;
        }
    }
}