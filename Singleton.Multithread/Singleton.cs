namespace Singleton.Multithread
{
    public class Singleton
    {        
        private static Singleton instance;

        private Singleton()
        {            
            Console.WriteLine($"Criou uma Instância.");
        }

        public static Singleton Instance { 
            get { 
                if (instance == null)
                    instance = new Singleton();
                return instance; 
            } 
        }
    }
}
