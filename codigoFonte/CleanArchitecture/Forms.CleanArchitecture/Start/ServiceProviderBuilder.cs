using Microsoft.Extensions.DependencyInjection;

namespace Forms.CleanArchitecture.Start
{
    internal class ServiceProviderBuilder
    {
        public static ServiceProvider Build()
        {
            var serviceCollection = new ServiceCollection();
            //serviceCollection.AddTransient<frmIncluirCliente>();
            //serviceCollection.AddTransient<frmGerenciarCliente>();
            //serviceCollection.AddTransient<frmIncluirUsuario>();
            //serviceCollection.AddTransient<frmMenu>();
            //serviceCollection.AddTransient<frmLogin>();
            //serviceCollection.AddScoped<SqlFactory>();
            //serviceCollection.AddTransient<IUsuarioRepository, UsuarioRepository>();
            //serviceCollection.AddTransient<IClienteRepository, ClienteRepository>();
            return serviceCollection.BuildServiceProvider();
        }
    }
}
