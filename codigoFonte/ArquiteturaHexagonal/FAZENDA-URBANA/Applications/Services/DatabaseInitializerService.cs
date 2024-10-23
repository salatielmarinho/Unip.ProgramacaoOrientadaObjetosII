using Applications.Interfaces;
using Infrastructure.Configuration;

namespace Applications.Services
{
    public class DatabaseInitializerService : IDatabaseInitializerService
    {
        private readonly RepositoryConfiguration _configuration;

        public DatabaseInitializerService(RepositoryConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void Initializer()
        {
            try
            {
                _configuration.dDatabaseInitializer.Initializer();
            }
            catch
            {
                throw;
            }
        }
    }
}