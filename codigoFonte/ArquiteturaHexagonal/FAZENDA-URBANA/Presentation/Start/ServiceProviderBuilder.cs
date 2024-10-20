using Applications.Configuration;
using Applications.Interfaces;
using Applications.Services;
using Domain.Interface;
using Infrastructure.Configuration;
using Infrastructure.Factory;
using Microsoft.Extensions.DependencyInjection;
using Presentation.ModuloCliente;
using Presentation.ModuloInicial;
using Presentation.ModuloUsuario;
using Repository.Repository;

namespace Presentation.Start
{
    public static class ServiceProviderBuilder
    {
        public static ServiceProvider Build()
        {
            var serviceCollection = new ServiceCollection();

            serviceCollection.AddTransient<frmIncluirCliente>();
            serviceCollection.AddTransient<frmGerenciarCliente>();
            serviceCollection.AddTransient<frmIncluirUsuario>();
            serviceCollection.AddTransient<frmMenu>();
            serviceCollection.AddTransient<frmLogin>();

            serviceCollection.AddScoped<SqlFactory>();

            serviceCollection.AddTransient<IUsuarioRepository, UsuarioRepository>();
            serviceCollection.AddTransient<IClienteRepository, ClienteRepository>();

            serviceCollection.AddTransient<IUsuarioService, UsuarioService>();
            serviceCollection.AddTransient<IClienteService, ClienteService>();

            serviceCollection.AddScoped<ServiceConfiguration>(provider => new ServiceConfiguration
            {
                clienteService = provider.GetRequiredService<IClienteService>(),
                usuarioService = provider.GetRequiredService<IUsuarioService>()
            });

            serviceCollection.AddScoped<RepositoryConfiguration>(provider => new RepositoryConfiguration
            {
                clienteRepository = provider.GetRequiredService<IClienteRepository>(),
                usuarioRepository = provider.GetRequiredService<IUsuarioRepository>()
            });

            return serviceCollection.BuildServiceProvider();
        }
    }
}