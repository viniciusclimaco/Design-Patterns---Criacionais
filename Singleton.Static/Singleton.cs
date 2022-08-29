namespace Singleton.Static
{
    public sealed class Singleton
    {
        private static int contador = 0;
        private static readonly Singleton instance;
        private Singleton()
        {

        }

        static Singleton()
        {
            contador++;
            Console.WriteLine("Criou uma instância");
            instance = new Singleton();
        }

        public static Singleton Instance
        {
            get { return instance; }
        }
    }
}
