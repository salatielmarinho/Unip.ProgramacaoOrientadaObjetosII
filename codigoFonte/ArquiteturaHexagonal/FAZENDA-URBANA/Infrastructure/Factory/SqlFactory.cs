using Microsoft.Data.SqlClient;
using System.Data;

namespace Infrastructure.Factory
{
    public class SqlFactory
    {
        public IDbConnection SqlConnection()
        {
            return new SqlConnection("Server=localhost;Initial Catalog=master;Integrated Security=True;Encrypt=False");
        }
    }
}