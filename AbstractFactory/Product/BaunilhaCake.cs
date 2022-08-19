using AbstractFactory.AbstractProduct;

namespace AbstractFactory.Product
{
    public class BaunilhaCake : Food
    {
        public override string Name => _name;
        private readonly string _name;

        public BaunilhaCake()
        {
            _name = "Bolo de Baunilha";
            Ingredients.Add("3 ovos grandes");
            Ingredients.Add("1 colher (chá) de essência de baunilha");
            Ingredients.Add("1/2 xícara de óleo");
            Ingredients.Add("2 xícaras de açúcar");
            Ingredients.Add("250 ml de leite");
            Ingredients.Add("3 xícaras de trigo");
            Ingredients.Add("1 colher (sobremesa) de fermento em pó");
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
            Console.WriteLine("Em uma batedeira, bata os ovos até ficarem bem clarinhos, adicione o óleo sem parar de bater.");
            Console.WriteLine("Adicione a baunilha, aos poucos o trigo e leite.");
            Console.WriteLine("Depois de bem batido, adicione o fermento e misture só por alguns segundos, pois, se bater muito depois de colocar o fermento o bolo não crescerá.");
            Console.WriteLine("Despeje a mistura em uma forma média, untada com margarina e trigo.");
            Console.WriteLine("Asse em forno médio, por aproximadamente 40 minutos, ou até dourar.");
            Console.WriteLine("");
        }

        public override void Serve()
        {
            Console.WriteLine($"Servindo o bolo de nome: {Name}");
        }
    }
}
