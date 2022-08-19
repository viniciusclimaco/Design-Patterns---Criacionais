using FactoryMethod.v2.ConcreteCreator;
using FactoryMethod.v2.Creator;
using FactoryMethod.v2.Product;

Console.WriteLine("Escolha seu café: ");
Console.WriteLine("(1) Latte | (2) Macchiato | (3) Expresso | (4) Irlandês");
var selected = Convert.ToInt32(Console.ReadLine());

try
{
    CooffeFactoryMethod cooffeFactory = new CooffeFactory();
    Cooffe cooffe = cooffeFactory.Create(selected);        
    cooffe.Preparar();
    cooffe.Servir();    
}
catch (Exception ex)
{
    Console.WriteLine("Erro: " + ex.Message);
}
Console.ReadLine();
