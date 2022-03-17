using LabAPP.Visual;
using Negocio;
using Repositorio.Config;
using System;
using System.Windows.Forms;
using Environments = Repositorio.Config.Environments;

namespace LabAPP
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            new UsuarioNegocio().ValidarDataBaseVazio();

            Env env = new();
            switch (env.Select)
            {
                case Environments.local:
                    Application.Run(new LoginVisualPreisser(Environments.local));
                    break;

                case Environments.beto:
                    Application.Run(new LoginVisualBeto(Environments.beto));
                    break;

                case Environments.preisser:
                    Application.Run(new LoginVisualPreisser(Environments.preisser));
                    break;

                case Environments.betoInMemory:
                    Application.Run(new LoginVisualBeto(Environments.betoInMemory));
                    break;

                case Environments.preisserInMemory:
                    Application.Run(new LoginVisualPreisser(Environments.preisserInMemory));
                    break;

                case Environments.paginaUnica:
                    Application.Run(new PaginaUnicaVisual());
                    break;

                default:
                    MessageBox.Show("A aplicação fechou de forma repentina");
                    Application.Exit();
                    break;
            }
        }
    }
}
