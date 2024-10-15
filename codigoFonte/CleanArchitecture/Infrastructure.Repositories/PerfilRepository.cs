using Domain.Entities;
using Domain.Interfaces;
using Infrastructure.Data;
using Microsoft.Data.SqlClient;
using System.Data;

namespace Infrastructure.Repositories
{
    public class PerfilRepository : IPerfilRepository
    {
        private readonly IDbConnection _connection;
        public PerfilRepository(SqlFactory factory)
        {
            _connection = factory.SqlConnection();
        }
        public bool AlterarPerfil(Perfil perfil)
        {
            bool alterarPerfil = false;
            try
            {
                _connection.Open();
                using (SqlCommand command = new SqlCommand("AlterarPerfil", (SqlConnection)_connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@PerfilID", perfil.PerfilId);
                    command.Parameters.AddWithValue("@NomePerfil", perfil.NomePerfil);

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
        public List<Perfil> ConsultarPerfil()
        {
            List<Perfil> lstPerfis = new List<Perfil>();
            try
            {
                _connection.Open();
                using (SqlCommand command = new SqlCommand("ConsultarPerfil", (SqlConnection)_connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Perfil perfil = new Perfil
                            {
                                PerfilId = (int)reader["PerfilID"],
                                NomePerfil = reader["NomePerfil"].ToString()
                            };
                            lstPerfis.Add(perfil);
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
            return lstPerfis;
        }
        public bool ExcluirPerfil(int perfilId)
        {
            bool excluirPerfil = false;
            try
            {
                _connection.Open();
                using (SqlCommand command = new SqlCommand("ExcluirPerfil", (SqlConnection)_connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@PerfilId", perfilId);

                    if (command.ExecuteNonQuery() > 0)
                    {
                        excluirPerfil = true;
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
        public bool InserirPerfil(Perfil perfil)
        {
            bool inserirPerfil = false;
            try
            {
                _connection.Open();
                using (SqlCommand command = new SqlCommand("InserirPerfil", (SqlConnection)_connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@NomePerfil", perfil.NomePerfil);

                    if (command.ExecuteNonQuery() > 0)
                    {
                        inserirPerfil = true;
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
            return inserirPerfil;
        }
    }
}