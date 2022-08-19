using FactoryMethod.v2.ConcreteProduct;
using FactoryMethod.v2.Creator;
using FactoryMethod.v2.Product;

namespace FactoryMethod.v2.ConcreteCreator
{
    public class CooffeFactory : CooffeFactoryMethod
    {   
        public override Cooffe Create(int tipo)
        {
            var factory = factories[tipo];
            return factory();
        }

        private static Dictionary<int, Func<Cooffe>> factories = new Dictionary<int, Func<Cooffe>>()
        {
            {1, () => new CooffeLatte()},
            {2, () => new CooffeMacchiato()},
            {3, () => new CooffeExpresso()},
            {4, () => new CooffeIrish()},            
        };
    }
}
