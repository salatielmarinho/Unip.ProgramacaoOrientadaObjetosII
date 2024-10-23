using Domain.Entities;
using Infrastructure.Factory;
using Infrastructure.Interfaces;
using Microsoft.Data.SqlClient;
using System.Data;

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
                        while (reader.Read())
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
            return excluirCliente;
        }
    }
}