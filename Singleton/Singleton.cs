namespace Singleton
{
    public class Singleton
    {
        private static Singleton instance;
        private int numIntancias = 0;
        private Singleton()
        {
            Console.WriteLine("Instanciando dentro do construtor privado");
            numIntancias++;
            Console.WriteLine($"Numero de instancias: {numIntancias}");
        }

        public static Singleton Instance { 
            get { 
                if (instance == null)
                {
                    Console.WriteLine("Criando a primeira instancia");
                    instance = new Singleton();
                }
                    
                return instance; 
            } 
        }
    }
}
