namespace Singleton.Multithread
{
    public class Singleton
    {
        private static int contador = 0;
        private static Singleton instance;

        private Singleton()
        {
            contador++;
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
