namespace Singleton.Lazy
{
    public sealed class Singleton
    {
        private static readonly Lazy<Singleton> instance = new Lazy<Singleton>(() => new Singleton());
        
        private Singleton()
        {            
            Console.WriteLine("Criou a instância");
        }

        public static Singleton Instance =>  instance.Value;
    }
}
