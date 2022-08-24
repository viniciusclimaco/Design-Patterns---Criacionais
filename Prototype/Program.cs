// Design Pattern: Prototype
using Prototype.ConcretePrototypes;
using Prototype.Prototypes;

Console.WriteLine("Padrão Prototype \n");

//Originais
Cooffe expresso = new CooffeExpresso();
expresso.Origin = new Prototype.Acessories.OriginCooffe() { Country = "Brasil" };

//Clone
Cooffe cloneExpresso;
Cooffe cloneExpressoDois;

cloneExpresso = expresso.Clone();
cloneExpresso.Ingredientes.Add("canela");

cloneExpressoDois = expresso.Clone();
cloneExpressoDois.Ingredientes.Add("óleo de coco");
cloneExpressoDois.Origin.Country = "Colômbia";

cloneExpresso.Preparar();
cloneExpresso.Servir();


Console.WriteLine("");
Console.WriteLine(" ------ ");
Console.WriteLine("");

cloneExpressoDois.Preparar();
cloneExpressoDois.Servir();

Console.ReadLine();

