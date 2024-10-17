using Desktop.ModuloInicial;
using Microsoft.Extensions.DependencyInjection;

namespace Desktop.Start
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