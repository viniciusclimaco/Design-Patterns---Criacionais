namespace SimpleFactory
{
    class CooffeIrish : Cooffe
    {
        public CooffeIrish()
        {
            Nome = "Café Irish ou Irlandês";
            Ingredientes = new List<string>() { "Café puro", "Uísque Irlandês", "Camada de Creme" };
        }
        
        public override void Servir()
        {
            Console.WriteLine($"Servindo o café de nome: {Nome}");
        }

        public override void Preparar()
        {
            Console.WriteLine($"Preparando o café {Nome}");
            Console.WriteLine($"Com os seguintes ingredientes:");
            for (int i = 0; i < Ingredientes.Count; i++)
            {
                Console.WriteLine($" - {Ingredientes[i]}");
            }
        }
    }
}
