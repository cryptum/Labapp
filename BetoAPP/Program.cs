using Negocio;
using Repositorio.Config;
using System;
using System.Windows.Forms;
using Environments = Repositorio.Config.Environments;

namespace BetoAPP
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

                default:
                    MessageBox.Show("A aplica��o fechou de forma repentina");
                    Application.Exit();
                    break;
            }
        }
    }
}
