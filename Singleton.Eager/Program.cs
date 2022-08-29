using Singleton.Eager;

Parallel.Invoke(
    () => AcessoThread1(),
    () => AcessoThread2()
    );

Console.ReadLine();

void AcessoThread1()
{
    Singleton.Eager.Singleton s1 = Singleton.Eager.Singleton.Instance;
    Console.WriteLine("Thread 1");
}

void AcessoThread2()
{
    Singleton.Eager.Singleton s2 = Singleton.Eager.Singleton.Instance;
    Console.WriteLine("Thread 2");
}
