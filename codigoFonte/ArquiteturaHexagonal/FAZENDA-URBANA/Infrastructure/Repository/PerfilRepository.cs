using Domain.Entities;
using Infrastructure.Factory;
using Infrastructure.Interfaces;
using Microsoft.Data.SqlClient;
using System.Data;

namespace Repository.Repository
{
    public class PerfilRepository : IPerfilRepository
    {
        private readonly IDbConnection _connection;

        public PerfilRepository(SqlFactory factory)
        {
            _connection = factory.SqlConnection();
        }

        public bool IncluirPerfil(Perfil Perfil)
        {
            bool incluirPerfil = false;
            try
            {
                _connection.Open();
                _connection.ChangeDatabase("BD_FAZENDA");
                using (SqlCommand command = new SqlCommand("InserirPerfil", (SqlConnection)_connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@NomePerfil", Perfil.NomePerfil);

                    if (command.ExecuteNonQuery() > 0)
                    {
                        incluirPerfil = true;
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
            return incluirPerfil;
        }

        public List<Perfil> ConsultarPerfil(string nomePerfil)
        {
            List<Perfil> lstPerfils = new List<Perfil>();
            try
            {
                _connection.Open();
                _connection.ChangeDatabase("BD_FAZENDA");
                using (SqlCommand command = new SqlCommand("ConsultarPerfil", (SqlConnection)_connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@NomePerfil", nomePerfil);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Perfil Perfil = new Perfil
                            {
                                Id = (int)reader["Id"],
                                NomePerfil = reader["NomePerfil"].ToString(),
                                DataCriacao = (DateTime)reader["DataCriacao"]
                            };
                            lstPerfils.Add(Perfil);
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
            return lstPerfils;
        }

        public List<Perfil> ConsultarTodosPerfis()
        {
            List<Perfil> lstPerfils = new List<Perfil>();
            try
            {
                _connection.Open();
                _connection.ChangeDatabase("BD_FAZENDA");
                using (SqlCommand command = new SqlCommand("ConsultarTodosPerfis", (SqlConnection)_connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Perfil Perfil = new Perfil
                            {
                                Id = (int)reader["Id"],
                                NomePerfil = reader["NomePerfil"].ToString()
                            };
                            lstPerfils.Add(Perfil);
                        }
                        reader.Close();
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
            return lstPerfils;
        }

        public bool AlterarPerfil(Perfil Perfil)
        {
            bool alterarPerfil = false;
            try
            {
                _connection.Open();
                _connection.ChangeDatabase("BD_FAZENDA");
                using (SqlCommand command = new SqlCommand("AlterarPerfil", (SqlConnection)_connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@NomePerfil", Perfil.NomePerfil);
                    command.Parameters.AddWithValue("@Id", Perfil.Id);

                    if (command.ExecuteNonQuery() > 0)
                    {
                        alterarPerfil = true;
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
            return alterarPerfil;
        }

        public bool ExcluirPerfil(int id)
        {
            bool excluirPerfil = false;
            try
            {
                _connection.Open();
                _connection.ChangeDatabase("BD_FAZENDA");
                using (SqlCommand command = new SqlCommand("ExcluirPerfil", (SqlConnection)_connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@Id", id);

                    if (command.ExecuteNonQuery() > 0)
                    {
                        excluirPerfil = true;
                        _connection.Close();
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
            return excluirPerfil;
        }
    }
}