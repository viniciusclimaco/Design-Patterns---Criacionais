namespace Singleton.Eager
{
    public sealed class Singleton
    {
        private static readonly Singleton instance = new Singleton();        

        private Singleton()
        {            
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
