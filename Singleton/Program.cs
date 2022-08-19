// See https://aka.ms/new-console-template for more information

Console.WriteLine("=== Padrão Singleton ====");

Console.WriteLine("Criando uma instancia 1");
Singleton.Singleton s1 = Singleton.Singleton.Instance;

Console.WriteLine("Criando uma instancia 2");
Singleton.Singleton s2 = Singleton.Singleton.Instance;
if (s1 == s2)
    Console.WriteLine("Existe somente uma instância (s1 == s2)");
else
    Console.WriteLine("Existem instâncias diferentes (s1 e s2)");

Console.Read();
