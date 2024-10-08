using System;
using System.Data.SqlClient;
using System.Data;
using System.Collections.Generic;
using Model;

namespace Controller
{
    public class AlunoController
    {
        public bool InserirAluno(AlunoModel alunoModel)
        {
            bool inserir = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(alunoModel.ConnectionStrings))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("InserirAluno", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@Nome", alunoModel.Nome);
                        command.Parameters.AddWithValue("@Idade", alunoModel.Idade);
                        command.Parameters.AddWithValue("@Curso", alunoModel.Curso);
                        command.Parameters.AddWithValue("@Email", alunoModel.Email);
                        command.Parameters.AddWithValue("@Endereco", alunoModel.Endereco);
                        command.Parameters.AddWithValue("@Telefone", alunoModel.Telefone);

                        if (command.ExecuteNonQuery() > 0)
                        {
                            inserir = true;
                        }
                        else
                        {
                            inserir = false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            return inserir;
        }
        public List<AlunoModel> ConsultarAlunos(string connectionStrings)
        {
            List<AlunoModel> alunos = new List<AlunoModel>();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionStrings))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("ConsultarAluno", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            AlunoModel aluno = new AlunoModel
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
                    }
                }
                return alunos;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}