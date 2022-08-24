using Prototype.Acessories;

namespace Prototype.Prototypes
{
    public abstract class Cooffe
    {
        public abstract string Nome { get; }        
        public List<string> Ingredientes = new List<string>();
        public OriginCooffe Origin { get; set; }

        public abstract Cooffe Clone();

        public abstract void Preparar();

        public abstract void Servir();

    }
}
