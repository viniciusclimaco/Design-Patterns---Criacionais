using AbstractFactory.AbstractProduct;

namespace AbstractFactory.Product
{
    public class CooffeExpresso : Food
    {
        public override string Name => _name;
        private readonly string _name;

        public CooffeExpresso()
        {
            _name = "Café Expresso";
            Ingredients.Add("Café Puro");
            Ingredients.Add("Sem Açúcar");
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
