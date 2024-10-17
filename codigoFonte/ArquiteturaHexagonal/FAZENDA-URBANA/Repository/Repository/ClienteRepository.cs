using Domain.Entities;
using Microsoft.Data.SqlClient;
using Repository.Interface;
using System.Data;
using Util.BD;

namespace Repository.Repository
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly IDbConnection _connection;

        public ClienteRepository(SqlFactory factory)
        {
            _connection = factory.SqlConnection();
        }

        public bool IncluirCliente(ClienteEntitie clienteEntitie)
        {
            bool incluirCliente = false;
            try
            {
                _connection.Open();
                using (SqlCommand command = new SqlCommand("InserirCliente", (SqlConnection)_connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@NomeCliente", clienteEntitie.NomeCliente);
                    command.Parameters.AddWithValue("@Cpf", clienteEntitie.Cpf);
                    command.Parameters.AddWithValue("@Email", clienteEntitie.Email);
                    command.Parameters.AddWithValue("@Senha", clienteEntitie.Senha);

                    if (command.ExecuteNonQuery() > 0)
                    {
                        incluirCliente = true;
                        _connection.Close();
                    }
                }
            }
            catch
            {
                _connection.Close();
                throw;
            }
            return incluirCliente;
        }

        public List<ClienteEntitie> ConsultarCliente(string nomeCliente)
        {
            List<ClienteEntitie> lstClienteEntitie = new List<ClienteEntitie>();
            try
            {
                _connection.Open();
                using (SqlCommand command = new SqlCommand("ConsultarCliente", (SqlConnection)_connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@NomeCliente", nomeCliente);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            ClienteEntitie clienteEntitie = new ClienteEntitie
                            {
                                Id = (int)reader["Id"],
                                NomeCliente = reader["NomeCliente"].ToString(),
                                Cpf = reader["Cpf"].ToString(),
                                Email = reader["Email"].ToString()
                            };
                            lstClienteEntitie.Add(clienteEntitie);
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
            return lstClienteEntitie;
        }

        public bool AlterarCliente(ClienteEntitie clienteEntitie)
        {
            bool alterarCliente = false;
            try
            {
                _connection.Open();
                using (SqlCommand command = new SqlCommand("AlterarCliente", (SqlConnection)_connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@NomeCliente", clienteEntitie.NomeCliente);
                    command.Parameters.AddWithValue("@Id", clienteEntitie.Id);

                    if (command.ExecuteNonQuery() > 0)
                    {
                        alterarCliente = true;
                        _connection.Close();
                    }
                }
            }
            catch
            {
                _connection.Close();
                throw;
            }
            return alterarCliente;
        }

        public bool ExcluirCliente(int id)
        {
            bool excluirCliente = false;
            try
            {
                _connection.Open();
                using (SqlCommand command = new SqlCommand("ExcluirCliente", (SqlConnection)_connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@Id", id);

                    if (command.ExecuteNonQuery() > 0)
                    {
                        excluirCliente = true;
                        _connection.Close();
                    }
                }
            }
            catch
            {
                _connection.Close();
                throw;
            }
            return excluirCliente;
        }
    }
}