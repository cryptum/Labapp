namespace Repositorio.Config
{
    public enum Environments
    {
        local = 1,
        beto = 2,
        preisser = 3,
        betoInMemory = 4,
        preisserInMemory = 5
    }

    public class Env
    {
        public Environments Select
        {
            get
            {
                return Environments.local;
            }
        }
    }
}
