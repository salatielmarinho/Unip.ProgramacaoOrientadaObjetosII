using Domain.Entities;
using Microsoft.Data.SqlClient;
using Repository.Interface;
using System.Data;
using Util.BD;

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
                        _connection.Close();
                    }
                }
            }
            catch
            {
                _connection.Close();
                throw;
            }
            return incluirUsuario;
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
                        if (reader.Read())
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
                    }
                    _connection.Close();
                }
            }
            catch
            {
                _connection.Close();
                throw;
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
                        _connection.Close();
                    }
                }
            }
            catch
            {
                _connection.Close();
                throw;
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
                        _connection.Close();
                    }
                }
            }
            catch
            {
                _connection.Close();
                throw;
            }
            return excluirUsuario;
        }
    }
}