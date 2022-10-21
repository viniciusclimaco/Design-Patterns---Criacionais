using SimpleFactory;

/* SEM Simple Factory */



//Cooffe cooffe = null;
//Console.WriteLine("===== Cafeteria Coders In Rio ======");
//Console.WriteLine("Informe o café que deseja: (L)atte | (M)acchiato | (I)rish | (L)atte");
//var selected = Console.ReadLine().ToUpper();
//try
//{
//    if (selected.Equals("M"))
//        cooffe = new CooffeMacchiato();
//    else if (selected.Equals("E"))
//        cooffe = new CooffeExpresso();
//    else if (selected.Equals("I"))
//        cooffe = new CooffeIrish();
//    else if (selected.Equals("L"))
//        cooffe = new CoffeLatte();
//    else
//    {
//        Console.WriteLine("Não tem a opção selecionada");
//        return;
//    }
//    cooffe.Preparar();    
//    cooffe.Servir();        
//}
//catch (Exception ex)
//{
//    Console.WriteLine($"Ocorreu um erro: {ex.Message}");
//}
//Console.ReadLine();




/* COM Simple Factory */


Console.WriteLine("===== Cafeteria Coders In Rio ======");
Console.WriteLine("Informe o café que deseja: (L)atte | (M)acchiato | (I)rish | (E)xpresso");
var selected = Console.ReadLine().ToUpper();
try
{
    Cooffe cooffe = CooffeSimpleFactory.CreateCooffe(selected);
    cooffe.Preparar();
    cooffe.Servir();
}
catch (Exception ex)
{
    Console.WriteLine($"Ocorreu um erro: {ex.Message}");
}
Console.ReadLine();
