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

        public bool IncluirUsuario(UsuarioEntitie usuarioEntitie)
        {
            bool incluirUsuario = false;
            try
            {
                _connection.Open();
                using (SqlCommand command = new SqlCommand("InserirUsuario", (SqlConnection)_connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@Nome", usuarioEntitie.Nome);
                    command.Parameters.AddWithValue("@Cep", usuarioEntitie.Cep);
                    command.Parameters.AddWithValue("@Endereco", usuarioEntitie.Endereco);
                    command.Parameters.AddWithValue("@Complemento", usuarioEntitie.Complemento);
                    command.Parameters.AddWithValue("@Numero", usuarioEntitie.Numero);
                    command.Parameters.AddWithValue("@Bairro", usuarioEntitie.Bairro);
                    command.Parameters.AddWithValue("@Uf", usuarioEntitie.Uf);
                    command.Parameters.AddWithValue("@Email", usuarioEntitie.Email);
                    command.Parameters.AddWithValue("@Senha", usuarioEntitie.Senha);

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

        public List<UsuarioEntitie> ConsultarUsuario(string nomeCliente)
        {
            List<UsuarioEntitie> lstUsuarioEntitie = new List<UsuarioEntitie>();
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
                            UsuarioEntitie usuarioEntitie = new UsuarioEntitie
                            {
                                Id = (int)reader["Id"],
                                Nome = reader["Nome"].ToString(),
                                Cep = reader["Cep"].ToString(),
                                Email = reader["Email"].ToString()
                            };
                            lstUsuarioEntitie.Add(usuarioEntitie);
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
            return lstUsuarioEntitie;
        }

        public bool AlterarUsuario(UsuarioEntitie usuarioEntitie)
        {
            bool alterarUsuario = false;
            try
            {
                _connection.Open();
                using (SqlCommand command = new SqlCommand("AlterarUsuario", (SqlConnection)_connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@Nome", usuarioEntitie.Nome);
                    command.Parameters.AddWithValue("@Id", usuarioEntitie.Id);

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