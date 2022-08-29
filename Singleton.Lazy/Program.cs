Parallel.Invoke(
    () => AcessoThread1(),
    () => AcessoThread2()
    );

Console.ReadLine();

static void AcessoThread1()
{
    Singleton.Lazy.Singleton s1 = Singleton.Lazy.Singleton.Instance;
    Console.WriteLine("Thread 1");
}

static void AcessoThread2()
{
    Singleton.Lazy.Singleton s2 = Singleton.Lazy.Singleton.Instance;
    Console.WriteLine("Thread 2");
}
