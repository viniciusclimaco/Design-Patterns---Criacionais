using AbstractFactory.AbstractFactory;
using AbstractFactory.AbstractProduct;
using AbstractFactory.ConcreteFactory;
using AbstractFactory.Enum;

Console.WriteLine("Escolha o que deseja consumir.");
Console.WriteLine("(1) Café Expresso | (2) Café Irish | (3) Bolo de Chocolate | (4) Bolo de Baunilha");
var selected = Convert.ToInt32(Console.ReadLine());

try
{    
    Food foodSelect = CreateFood(selected);
    if (foodSelect != null)
    {
        foodSelect.Prepare();
        foodSelect.Serve();
    }    
}
catch (Exception ex)
{
    Console.WriteLine("Erro: " + ex.Message);
}
Console.ReadLine();


Food CreateFood(int select)
{
    IFoodFactory factory;
    Food food;
    switch (selected)
    {        
        case 1:
            factory = new CooffeFactory();
            food = factory.GetFood((int)TypeCooffe.Expresso);
            return food;
        case 2:
            factory = new CooffeFactory();            
            food = factory.GetFood((int)TypeCooffe.Irish);
            break;
        case 3:
            factory = new CakeFactory();
            food = factory.GetFood((int)TypeCake.Chocolate);
            break;
        case 4:
            factory = new CakeFactory();
            food = factory.GetFood((int)TypeCake.Baunilha);
            break;
        default:
            return null;            
    }
    return food;
}
