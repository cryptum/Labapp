namespace Repositorio.Config
{
    public enum Environments
    {
        local,
        beto,
        preisser,
        betoInMemory,
        preisserInMemory,
        paginaUnica,
        paginaUnicaInMemory,
    }

    public class Env
    {
        public Environments Select
        {
            get
            {
                return Environments.paginaUnicaInMemory;
            }
        }
    }
}
