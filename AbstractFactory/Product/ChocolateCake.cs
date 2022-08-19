using AbstractFactory.AbstractProduct;

namespace AbstractFactory.Product
{
    public class ChocolateCake : Food
    {
        public override string Name => _name;
        private readonly string _name;

        public ChocolateCake()
        {
            _name = "Bolo de Chocolate";
            Ingredients.Add("4 ovos");
            Ingredients.Add("4 colheres (sopa) de chocolate em pó");
            Ingredients.Add("2 colheres (sopa) de manteiga");
            Ingredients.Add("3 xícaras (chá) de farinha de trigo");
            Ingredients.Add("2 xícaras (chá) de açúcar");
            Ingredients.Add("2 colheres (sopa) de fermento");
            Ingredients.Add("1 xícara (chá) de leite");
        }

        public override void Prepare()
        {
            Console.WriteLine($"Preparando o {Name}");
            Console.WriteLine($"Com os seguintes ingredientes:");
            for (int i = 0; i < Ingredients.Count; i++)
            {
                Console.WriteLine($" - {Ingredients[i]}");
            }
            Console.WriteLine("");
            Console.WriteLine("Em um liquidificador adicione os ovos, o chocolate em pó, a manteiga, a farinha de trigo, o açúcar e o leite, depois bata por 5 minutos");
            Console.WriteLine("Adicione o fermento e misture com uma espátula delicadamente");
            Console.WriteLine("Em uma forma untada, despeje a massa e asse em forno médio (180 ºC) preaquecido por cerca de 40 minutos.");
            Console.WriteLine("");
        }

        public override void Serve()
        {
            Console.WriteLine($"Servindo o bolo de nome: {Name}");
        }
    }
}
