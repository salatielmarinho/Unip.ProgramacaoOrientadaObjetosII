using Domain.Entities.Entities;
using Domain.Interfaces;
using Infrastructure.Data.Factory;
using Microsoft.Data.SqlClient;
using System.Data;

namespace Infrastructure.Repositories.Repositories
{
    public class CursoRepository : ICursoRepository
    {
        private readonly IDbConnection _connection;
        public CursoRepository(SqlFactory factory)
        {
            _connection = factory.SqlConnection();
        }
        public bool AlterarCurso(Curso curso)
        {
            bool alterarCurso = false;
            try
            {
                _connection.Open();
                using (SqlCommand command = new SqlCommand("AlterarCurso", (SqlConnection)_connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@Id", curso.Id);
                    command.Parameters.AddWithValue("@Nome", curso.Nome);
                    command.Parameters.AddWithValue("@Descricao", curso.Descricao);
                    command.Parameters.AddWithValue("@Status", curso.Status);

                    if (command.ExecuteNonQuery() > 0)
                    {
                        alterarCurso = true;
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
            return alterarCurso;
        }
        public List<Curso> ConsultaCursos()
        {
            List<Curso> lstCursos = new List<Curso>();
            try
            {
                _connection.Open();
                using (SqlCommand command = new SqlCommand("ConsultarCurso", (SqlConnection)_connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Curso curso = new Curso
                            {
                                Id = (int)reader["Id"],
                                Nome = reader["Nome"].ToString(),
                                Descricao = reader["Descricao"].ToString(),
                                Status = (bool)reader["Status"],
                                DataCriacao = (DateTime)reader["DataCriacao"]

                            };
                            lstCursos.Add(curso);
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
            return lstCursos;
        }
        public bool ExcluirCurso(int id)
        {
            bool excluirCurso = false;
            try
            {
                _connection.Open();
                using (SqlCommand command = new SqlCommand("ExcluirCurso", (SqlConnection)_connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@Id", id);

                    if (command.ExecuteNonQuery() > 0)
                    {
                        excluirCurso = true;
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
            return excluirCurso;
        }
        public bool InserirCurso(Curso curso)
        {
            bool inserirCurso = false;
            try
            {
                _connection.Open();
                using (SqlCommand command = new SqlCommand("InserirCurso", (SqlConnection)_connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@Nome", curso.Nome);
                    command.Parameters.AddWithValue("@Descricao", curso.Descricao);

                    if (command.ExecuteNonQuery() > 0)
                    {
                        inserirCurso = true;
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
            return inserirCurso;
        }
    }
}