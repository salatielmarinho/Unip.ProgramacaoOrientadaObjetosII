﻿using Applications.Configuration;
using Applications.Interfaces;
using Applications.Services;
using Infrastructure.Configuration;
using Infrastructure.Factory;
using Infrastructure.Interface;
using Microsoft.Extensions.DependencyInjection;
using Presentation.ModuloCliente;
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
            serviceCollection.AddTransient<frmGerenciarCliente>();
            serviceCollection.AddTransient<frmIncluirUsuario>();
            serviceCollection.AddTransient<frmMenu>();
            serviceCollection.AddTransient<frmLogin>();

            //Factory
            serviceCollection.AddScoped<SqlFactory>();

            //Repository
            serviceCollection.AddTransient<IUsuarioRepository, UsuarioRepository>();
            serviceCollection.AddTransient<IClienteRepository, ClienteRepository>();
            serviceCollection.AddTransient<IPerfilRepository, PerfilRepository>();

            //Service
            serviceCollection.AddTransient<IUsuarioService, UsuarioService>();
            serviceCollection.AddTransient<IClienteService, ClienteService>();
            serviceCollection.AddTransient<IPerfilService, PerfilService>();

            //ConfigurationService
            serviceCollection.AddScoped<ServiceConfiguration>(provider => new ServiceConfiguration
            {
                clienteService = provider.GetRequiredService<IClienteService>(),
                usuarioService = provider.GetRequiredService<IUsuarioService>(),
                perfilService = provider.GetRequiredService<IPerfilService>()
            });

            //ConfigurationRepository
            serviceCollection.AddScoped<RepositoryConfiguration>(provider => new RepositoryConfiguration
            {
                clienteRepository = provider.GetRequiredService<IClienteRepository>(),
                usuarioRepository = provider.GetRequiredService<IUsuarioRepository>(),
                perfilRepository = provider.GetRequiredService<IPerfilRepository>()
            });

            return serviceCollection.BuildServiceProvider();
        }
    }
}