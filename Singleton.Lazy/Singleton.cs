namespace Singleton.Lazy
{
    public sealed class Singleton
    {
        private static readonly Lazy<Singleton> instance = new Lazy<Singleton>(() => new Singleton());
        private static int contador = 0;
        private Singleton()
        {
            contador++;
            Console.WriteLine("Criou a instância");
        }

        public static Singleton Instance { get { return instance.Value; } }
    }
}
