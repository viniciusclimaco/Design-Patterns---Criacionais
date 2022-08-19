namespace SimpleFactory
{
    abstract class Cooffe
    {
        public string Nome { get; set; }
        public List<string> Ingredientes { get; set; }

        public abstract void Preparar();        
        public abstract void Servir();
    }
}
