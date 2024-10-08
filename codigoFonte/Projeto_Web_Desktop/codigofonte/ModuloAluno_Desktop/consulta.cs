using System;
using System.Collections.Generic;
using System.Data.SqlClient;

public class AlunosController
{
    private string connectionString = "";

    public List<Aluno> ConsultarAlunos()
    {
        List<Aluno> alunos = new List<Aluno>();
		try
		{
			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				connection.Open();
				using (SqlCommand command = new SqlCommand("ConsultarAluno", connection);
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
				}	
			}
			return alunos;
		}
		catch(Excepetion)
		{
			throw;
		}
    }
}