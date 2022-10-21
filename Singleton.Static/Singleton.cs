namespace Singleton.Static
{
    public sealed class Singleton
    {        
        private static readonly Singleton instance = new Singleton();
        private Singleton() {
        }

        static Singleton()
        {            
            Console.WriteLine("Criou uma instância");            
        }

        public static Singleton Instance => instance;
        
    }
}
