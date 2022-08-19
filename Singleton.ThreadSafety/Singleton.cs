﻿namespace Singleton.ThreadSafety
{
    public class Singleton
    {
        private static int contador = 0;
        private static Singleton instance = null;
        private static readonly object lockObject = new object();
        private Singleton()
        {
            contador++;
            Console.WriteLine($"Criou uma Instância.");
        }

        public static Singleton Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (lockObject)
                    {
                        if (instance == null)
                            instance = new Singleton();                        
                    }
                }
                return instance;
            }
        }
    }
}
