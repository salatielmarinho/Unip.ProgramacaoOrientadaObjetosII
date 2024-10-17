using Microsoft.Data.SqlClient;
using System.Data;

namespace Infrastructure.Data.Factory
{
    public class SqlFactory
    {
        public IDbConnection SqlConnection()
        {
            return new SqlConnection("Server=localhost;Initial Catalog=POOII;Integrated Security=True;Encrypt=False");
        }
    }
}