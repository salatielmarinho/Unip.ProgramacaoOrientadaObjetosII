using Microsoft.Data.SqlClient;
using System.Data;

namespace Util.BD
{
    public class SqlFactory
    {
        public IDbConnection SqlConnection()
        {
            return new SqlConnection("Server=localhost;Initial Catalog=BD_FAZENDA;Integrated Security=True;Encrypt=False");
        }
    }
}