// See https://aka.ms/new-console-template for more information
Parallel.Invoke(
    () => AcessoThread1(),
    () => AcessoThread2()
    );

Console.ReadLine();

static void AcessoThread1()
{
    Singleton.Multithread.Singleton s1 = Singleton.Multithread.Singleton.Instance;
    Console.WriteLine("Thread 1");
}

static void AcessoThread2()
{
    Singleton.Multithread.Singleton s2 = Singleton.Multithread.Singleton.Instance;
    Console.WriteLine("Thread 2");
}