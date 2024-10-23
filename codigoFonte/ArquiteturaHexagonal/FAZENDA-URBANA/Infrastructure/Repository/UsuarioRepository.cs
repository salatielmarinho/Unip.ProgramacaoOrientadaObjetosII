using Domain.Entities;
using Infrastructure.Factory;
using Infrastructure.Interfaces;
using Microsoft.Data.SqlClient;
using System.Data;

namespace Repository.Repository
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly IDbConnection _connection;

        public UsuarioRepository(SqlFactory factory)
        {
            _connection = factory.SqlConnection();
        }

        public bool IncluirUsuario(Usuario usuario)
        {
            bool incluirUsuario = false;
            try
            {
                _connection.Open();
                using (SqlCommand command = new SqlCommand("InserirUsuario", (SqlConnection)_connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@Fk_Perfil", usuario.Fk_Perfil);
                    command.Parameters.AddWithValue("@Nome", usuario.Nome);
                    command.Parameters.AddWithValue("@Cep", usuario.Cep);
                    command.Parameters.AddWithValue("@Endereco", usuario.Endereco);
                    command.Parameters.AddWithValue("@Complemento", usuario.Complemento);
                    command.Parameters.AddWithValue("@Numero", usuario.Numero);
                    command.Parameters.AddWithValue("@Bairro", usuario.Bairro);
                    command.Parameters.AddWithValue("@Uf", usuario.Uf);
                    command.Parameters.AddWithValue("@Email", usuario.Email);
                    command.Parameters.AddWithValue("@Senha", usuario.Senha);

                    if (command.ExecuteNonQuery() > 0)
                    {
                        incluirUsuario = true;
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
            return incluirUsuario;
        }

        public int ConsultarPerfilUsuario(Usuario usuario)
        {
            int fkPerfil = 0;
            try
            {
                _connection.Open();
                using (SqlCommand command = new SqlCommand("ConsultarPerfilUsuario", (SqlConnection)_connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@NomeUsuario", usuario.Nome);
                    command.Parameters.AddWithValue("@Senha", usuario.Senha);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            fkPerfil = (int)reader["Fk_Perfil"];
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
            return fkPerfil;
        }

        public List<Usuario> ConsultarUsuario(string nomeCliente)
        {
            List<Usuario> lstUsuarios = new List<Usuario>();
            try
            {
                _connection.Open();
                using (SqlCommand command = new SqlCommand("ConsultarUsuario", (SqlConnection)_connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@Nome", nomeCliente);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Usuario usuario = new Usuario
                            {
                                Id = (int)reader["Id"],
                                NomePerfil = reader["NomePerfil"].ToString(),
                                Nome = reader["Nome"].ToString(),
                                Cep = reader["Cep"].ToString(),
                                Endereco = reader["Endereco"].ToString(),
                                Complemento = reader["Complemento"].ToString(),
                                Numero = reader["Numero"].ToString(),
                                Bairro = reader["Bairro"].ToString(),
                                Uf = reader["UF"].ToString(),
                                Email = reader["Email"].ToString(),
                                DataCriacao = (DateTime)reader["DataCriacao"]

                            };
                            lstUsuarios.Add(usuario);
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
            return lstUsuarios;
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

                    command.Parameters.AddWithValue("@Nome", usuario.Nome);
                    command.Parameters.AddWithValue("@Id", usuario.Id);

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

        public bool ExcluirUsuario(int id)
        {
            bool excluirUsuario = false;
            try
            {
                _connection.Open();
                using (SqlCommand command = new SqlCommand("ExcluirUsuario", (SqlConnection)_connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@Id", id);

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
    }
}