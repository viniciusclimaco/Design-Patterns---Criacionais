using Builder.ConcreteBuilders;
using Builder.Directors;
using Builder.Products;

//Builder
SandwichBuilder builder = new SandwichBuilder();

//Director
Director director = new Director(builder);
director.CreateBigMac();

//Product
Sandwich sandwich = builder.GetProduct();

Console.WriteLine($"Acaba de sair um sanduiche: {sandwich.SandwichType.ToString()}");

director.CreateBigTasty();
sandwich = builder.GetProduct();
Console.WriteLine($"Acaba de sair um sanduiche: {sandwich.SandwichType.ToString()}");

Console.ReadKey();

