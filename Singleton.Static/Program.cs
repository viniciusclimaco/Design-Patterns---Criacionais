Parallel.Invoke(
    () => AcessoThread1(),
    () => AcessoThread2()
    );

Console.ReadLine();

static void AcessoThread1()
{
    Singleton.Static.Singleton s1 = Singleton.Static.Singleton.Instance;
    Console.WriteLine("Thread 1");
}

static void AcessoThread2()
{
    Singleton.Static.Singleton s2 = Singleton.Static.Singleton.Instance;
    Console.WriteLine("Thread 2");
}

