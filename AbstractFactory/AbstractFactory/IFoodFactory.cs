using AbstractFactory.AbstractProduct;

namespace AbstractFactory.AbstractFactory
{
    internal interface IFoodFactory
    {
        Food GetFood(int typeFood);
    }
}
