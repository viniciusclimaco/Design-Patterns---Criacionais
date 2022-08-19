using System.Collections;

namespace FactoryMethod.v2.Product
{
    public abstract class Cooffe
    {
        public abstract string Nome { get;  }
        public List<string> Ingredientes = new List<string>();

        public abstract void Preparar();

        public abstract void Servir();
        
    }
}
