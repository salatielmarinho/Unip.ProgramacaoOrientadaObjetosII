using Microsoft.Data.SqlClient;
using System.Data;

namespace API.Infrastructure.Shared.Factory
{
    public class SqlFactory
    {
        public IDbConnection SqlConnection()
        {
            return new SqlConnection("Server=localhost;Initial Catalog=MVP;Integrated Security=True;Encrypt=False");
        }
    }
}
