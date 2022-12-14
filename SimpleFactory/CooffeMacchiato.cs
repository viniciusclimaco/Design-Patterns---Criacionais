namespace SimpleFactory
{
    class CooffeMacchiato : Cooffe
    {
        public CooffeMacchiato()
        {
            Nome = "Café Macchiato";
            Ingredientes = new List<string>() { "Café puro", "Leite", "Açúcar" };
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
