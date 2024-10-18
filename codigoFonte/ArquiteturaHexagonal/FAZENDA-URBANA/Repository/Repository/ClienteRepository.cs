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

        public bool IncluirCliente(Cliente cliente)
        {
            bool incluirCliente = false;
            try
            {
                _connection.Open();
                using (SqlCommand command = new SqlCommand("InserirCliente", (SqlConnection)_connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@NomeCliente", cliente.NomeCliente);
                    command.Parameters.AddWithValue("@Cpf", cliente.Cpf);
                    command.Parameters.AddWithValue("@Email", cliente.Email);

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

        public List<Cliente> ConsultarCliente(string nomeCliente)
        {
            List<Cliente> lstClientes = new List<Cliente>();
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
                            Cliente cliente = new Cliente
                            {
                                Id = (int)reader["Id"],
                                NomeCliente = reader["NomeCliente"].ToString(),
                                Cpf = reader["Cpf"].ToString(),
                                Email = reader["Email"].ToString(),
                                DataCriacao = (DateTime)reader["DataCriacao"]
                            };
                            lstClientes.Add(cliente);
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
            return lstClientes;
        }

        public bool AlterarCliente(Cliente cliente)
        {
            bool alterarCliente = false;
            try
            {
                _connection.Open();
                using (SqlCommand command = new SqlCommand("AlterarCliente", (SqlConnection)_connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@NomeCliente", cliente.NomeCliente);
                    command.Parameters.AddWithValue("@Id", cliente.Id);

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