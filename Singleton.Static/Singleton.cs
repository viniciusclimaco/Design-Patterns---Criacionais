namespace Singleton.Static
{
    public sealed class Singleton
    {        
        private static readonly Singleton instance;
        private Singleton() {
        }

        static Singleton()
        {            
            Console.WriteLine("Criou uma instância");
            instance = new Singleton();
        }

        public static Singleton Instance => instance;
        
    }
}
