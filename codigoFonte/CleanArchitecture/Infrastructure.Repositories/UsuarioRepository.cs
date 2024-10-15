using Domain.Entities;
using Domain.Interfaces;
using Infrastructure.Data;
using Microsoft.Data.SqlClient;
using System.Data;

namespace Infrastructure.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly IDbConnection _connection;
        public UsuarioRepository(SqlFactory factory)
        {
            _connection = factory.SqlConnection();
        }
        public bool AlterarUsuario(Usuario usuario)
        {
            bool alterarUsuario = false;
            try
            {
                _connection.Open();
                using (SqlCommand command = new SqlCommand("AlterarUsuario", (SqlConnection)_connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@UsuarioID", usuario.UsuarioID);
                    command.Parameters.AddWithValue("@Nome", usuario.Nome);
                    command.Parameters.AddWithValue("@Email", usuario.Email);
                    command.Parameters.AddWithValue("@Senha", usuario.Senha);

                    if (command.ExecuteNonQuery() > 0)
                    {
                        alterarUsuario = true;
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
            return alterarUsuario;
        }
        public List<Usuario> ConsultarUsuario()
        {
            List<Usuario> lstUsuarios = new List<Usuario>();
            try
            {
                _connection.Open();
                using (SqlCommand command = new SqlCommand("ConsultarUsuario", (SqlConnection)_connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Usuario usuario = new Usuario
                            {
                                UsuarioID = (int)reader["UsuarioID"],
                                Nome = reader["Nome"].ToString(),
                                Email = reader["Email"].ToString(),
                                DataCriacao = (DateTime)reader["Senha"]
                            };
                            lstUsuarios.Add(usuario);
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
            return lstUsuarios;
        }
        public bool ExcluirUsuario(int usuarioId)
        {
            bool excluirUsuario = false;
            try
            {
                _connection.Open();
                using (SqlCommand command = new SqlCommand("ExcluirUsuario", (SqlConnection)_connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@UsuarioId", usuarioId);

                    if (command.ExecuteNonQuery() > 0)
                    {
                        excluirUsuario = true;
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
            return excluirUsuario;
        }
        public bool InserirUsuario(Usuario usuario)
        {
            bool inserirUsuario = false;
            try
            {
                _connection.Open();
                using (SqlCommand command = new SqlCommand("InserirUsuario", (SqlConnection)_connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@Nome", usuario.Nome);
                    command.Parameters.AddWithValue("@Email", usuario.Email);
                    command.Parameters.AddWithValue("@Senha", usuario.Senha);

                    if (command.ExecuteNonQuery() > 0)
                    {
                        inserirUsuario = true;
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
            return inserirUsuario;
        }
    }
}