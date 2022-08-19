using AbstractFactory.AbstractFactory;
using AbstractFactory.AbstractProduct;
using AbstractFactory.Product;
using AbstractFactory.Enum;

namespace AbstractFactory.ConcreteFactory
{
    internal class CooffeFactory : IFoodFactory
    {
        public Food GetFood(int typeFood)
        {
            var selected = (TypeCooffe)typeFood;
            switch (selected)
            {
                case TypeCooffe.Expresso:
                    return new CooffeExpresso();
                case TypeCooffe.Irish:
                    return new CooffeIrish();
                default:
                    throw new ArgumentOutOfRangeException("Café não encontrado.");
            }
        }
    }
}
