using AbstractFactory.AbstractFactory;
using AbstractFactory.AbstractProduct;
using AbstractFactory.Product;
using AbstractFactory.Enum;

namespace AbstractFactory.ConcreteFactory
{
    internal class CakeFactory : IFoodFactory
    {
        public Food GetFood(int typeFood)
        {
            var selected = (TypeCake)typeFood;
            switch (selected)
            {
                case TypeCake.Baunilha:
                    return new BaunilhaCake();
                case TypeCake.Chocolate:
                    return new ChocolateCake();
                default:
                    throw new ArgumentOutOfRangeException("Bolo não encontrado.");
            }
        }

    }
}
