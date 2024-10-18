using Microsoft.Data.SqlClient;
using System.Data;

namespace Util.BD
{
    public class SqlFactory
    {
        public IDbConnection SqlConnection()
        {
            //return new SqlConnection("Adicionar aqui connectionString gerada no laboratório");
            return new SqlConnection("Server=localhost;Initial Catalog=BD_FAZENDA;Integrated Security=True;Encrypt=False");
        }
    }
}