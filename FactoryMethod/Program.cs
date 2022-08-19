// See https://aka.ms/new-console-template for more information
using FactoryMethod;

Console.WriteLine("===== PIZZARIA =======");
Console.WriteLine("INFORME O LOCAL (S) SÃO PAULO / (R) RIO DE JANEIRO");
var localEscolhido = Console.ReadLine().ToUpper();

Console.WriteLine("Escolha a pizza (M)ussarela ou (C)alabreza");
var pizzaEscolhida = Console.ReadLine().ToUpper();

try
{
    PizzaFactoryMethod pizzaria = PizzaSimpleFactory.CriarPizzaria(localEscolhido);
    var pizza = pizzaria.MontaPizza(pizzaEscolhida);
    Console.WriteLine(pizza.Preparar());
    Console.WriteLine("\nPizza conluída com sucesso.");
}
catch (Exception ex)
{
    Console.WriteLine("Erro: " + ex.Message);
    throw;
}
