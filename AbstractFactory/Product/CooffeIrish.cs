using AbstractFactory.AbstractProduct;

namespace AbstractFactory.Product
{
    public class CooffeIrish : Food
    {
        public override string Name => _name;
        private readonly string _name;

        public CooffeIrish()
        {
            _name = "Café Irlandês";
            Ingredients.Add("Café Puro");
            Ingredients.Add("Camada de Creme");
            Ingredients.Add("Uísque Irlandês");
        }

        public override void Prepare()
        {
            Console.WriteLine($"Servindo o café de nome: {Name}");
        }

        public override void Serve()
        {
            Console.WriteLine($"Preparando o café {Name}");
            Console.WriteLine($"Com os seguintes ingredientes:");
            for (int i = 0; i < Ingredients.Count; i++)
            {
                Console.WriteLine($" - {Ingredients[i]}");
            }
        }
    }
}
