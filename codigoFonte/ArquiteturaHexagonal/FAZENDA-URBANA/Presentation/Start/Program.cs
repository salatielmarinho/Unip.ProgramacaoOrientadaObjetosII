using Microsoft.Extensions.DependencyInjection;
using Presentation.ModuloInicial;

namespace Presentation.Start
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var serviceProvider = ServiceProviderBuilder.Build();
            var mainForm = serviceProvider.GetRequiredService<frmLogin>();
            Application.Run(mainForm);
        }
    }
}