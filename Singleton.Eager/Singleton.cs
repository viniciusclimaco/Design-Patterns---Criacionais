namespace Singleton.Eager
{
    public sealed class Singleton
    {
        private static readonly Singleton instance = new Singleton();
        private static int contador = 0;

        private Singleton()
        {
            contador++;
            Console.WriteLine("Criou instância");
        }

        public static Singleton Instance
        {
            get
            {
                return instance;
            }
        }
    }
}
