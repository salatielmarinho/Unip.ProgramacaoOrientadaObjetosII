using Infrastructure.Factory;
using Infrastructure.Interfaces;
using Microsoft.Data.SqlClient;
using System.Data;

namespace Repository.Repository
{
    public class DatabaseInitializerRepository : IDatabaseInitializerRepository
    {
        private readonly IDbConnection _connection;

        public DatabaseInitializerRepository(SqlFactory factory)
        {
            _connection = factory.SqlConnection();
        }

        public void ExecuteNonQuery(string commandText)
        {
            try
            {
                _connection.Open();
                using (SqlCommand command = new SqlCommand(commandText, (SqlConnection)_connection))
                {
                    command.ExecuteNonQuery();
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
        }
    }
}