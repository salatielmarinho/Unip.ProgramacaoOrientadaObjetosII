using Core;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Infrastructure
{
    public class AlunoService : IAlunoService
    {
        private readonly String _connectionString;

        public AlunoService(string connectionString)
        {
            _connectionString = connectionString;
        }

        public bool InserirAluno(Aluno aluno)
        {
            bool result = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("InserirAluno", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@Nome", aluno.Nome);
                        command.Parameters.AddWithValue("@Idade", aluno.Idade);
                        command.Parameters.AddWithValue("@Curso", aluno.Curso);
                        command.Parameters.AddWithValue("@Email", aluno.Email);
                        command.Parameters.AddWithValue("@Endereco", aluno.Endereco);
                        command.Parameters.AddWithValue("@Telefone", aluno.Telefone);

                        if (command.ExecuteNonQuery() > 0)
                        {
                            connection.Close();
                            result = true;
                        }
                    }
                }
                return result;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public bool AlterarAluno(Aluno aluno)
        {
            bool result = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("AlterarAluno", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@Id", aluno.Id);
                        command.Parameters.AddWithValue("@Nome", aluno.Nome);

                        if (command.ExecuteNonQuery() > 0)
                        {
                            connection.Close();
                            result = true;
                        }
                    }
                }
                return result;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public bool ExcluirAluno(Aluno aluno)
        {
            bool result = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("ExcluirAluno", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@Id", aluno.Id);

                        if (command.ExecuteNonQuery() > 0)
                        {
                            connection.Close();
                            result = true;
                        }
                    }
                }
                return result;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public List<Aluno> ConsultarAluno(int id)
        {
            List<Aluno> alunos = new List<Aluno>();
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("ConsultarAluno", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            Aluno aluno = new Aluno
                            {
                                Id = reader.GetInt32(0),
                                Nome = reader.GetString(1),
                                Idade = reader.GetInt32(2),
                                Curso = reader.GetString(3),
                                Email = reader.GetString(4),
                                DataDeMatricula = reader.GetDateTime(5),
                                Endereco = reader.GetString(6),
                                Telefone = reader.GetString(7)
                            };
                            alunos.Add(aluno);
                        }
                        reader.Close();
                        connection.Close();
                    }
                }
                return alunos;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}