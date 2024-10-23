using Applications.Configuration;
using Applications.Interfaces;
using Applications.Services;
using Infrastructure.Configuration;
using Infrastructure.Factory;
using Infrastructure.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Presentation.ModuloInicial;
using Presentation.ModuloPerfil;
using Presentation.ModuloUsuario;
using Repository.Repository;

namespace Presentation.Start
{
    public static class ServiceProviderBuilder
    {
        public static ServiceProvider Build()
        {
            var serviceCollection = new ServiceCollection();

            //Forms
            serviceCollection.AddTransient<frmIncluirPerfil>();
            serviceCollection.AddTransient<ModuloCliente.frmGerenciarCliente>();
            serviceCollection.AddTransient<frmIncluirUsuario>();
            serviceCollection.AddTransient<frmMenu>();
            serviceCollection.AddTransient<frmLogin>();

            //Factory
            serviceCollection.AddScoped<SqlFactory>();

            //Repository
            serviceCollection.AddTransient<IDatabaseInitializerRepository, DatabaseInitializerRepository>();
            serviceCollection.AddTransient<IUsuarioRepository, UsuarioRepository>();
            serviceCollection.AddTransient<IClienteRepository, ClienteRepository>();
            serviceCollection.AddTransient<IPerfilRepository, PerfilRepository>();

            //Service
            serviceCollection.AddTransient<IDatabaseInitializerService, DatabaseInitializerService>();
            serviceCollection.AddTransient<IUsuarioService, UsuarioService>();
            serviceCollection.AddTransient<IClienteService, ClienteService>();
            serviceCollection.AddTransient<IPerfilService, PerfilService>();

            //ConfigurationService
            serviceCollection.AddScoped<ServiceConfiguration>(provider => new ServiceConfiguration
            {
                clienteService = provider.GetRequiredService<IClienteService>(),
                databaseInitializerService = provider.GetRequiredService<IDatabaseInitializerService>(),
                usuarioService = provider.GetRequiredService<IUsuarioService>(),
                perfilService = provider.GetRequiredService<IPerfilService>()
            });

            //ConfigurationRepository
            serviceCollection.AddScoped<RepositoryConfiguration>(provider => new RepositoryConfiguration
            {
                clienteRepository = provider.GetRequiredService<IClienteRepository>(),
                databaseInitializerRepository = provider.GetRequiredService<IDatabaseInitializerRepository>(),
                perfilRepository = provider.GetRequiredService<IPerfilRepository>(),
                usuarioRepository = provider.GetRequiredService<IUsuarioRepository>()
            });

            return serviceCollection.BuildServiceProvider();
        }
    }
}