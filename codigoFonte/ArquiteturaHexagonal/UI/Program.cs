using Core;
using Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Configuration;
using System.Windows.Forms;

namespace UI
{
    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            var services = new ServiceCollection();
            ConfigureServices(services);
            using (var serviceProvider = services.BuildServiceProvider())
            {
                var frmIncluirAluno = serviceProvider.GetRequiredService<frmIncluirAluno>();
                Application.Run(frmIncluirAluno);
            }
        }
        private static void ConfigureServices(IServiceCollection services)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["UNIP_Desenvolvimento"].ConnectionString;
            services.AddTransient<IAlunoService>(provider => new AlunoService(connectionString));
            services.AddTransient<frmIncluirAluno>();
        }
    }
}