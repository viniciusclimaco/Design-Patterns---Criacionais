Parallel.Invoke(
    () => Thread1(),
    () => Thread2()
    );

Console.ReadLine();

static void Thread1()
{
    Singleton.ThreadSafety.Singleton s1 = Singleton.ThreadSafety.Singleton.Instance;
    Console.WriteLine("Thread 1");
}

static void Thread2()
{
    Singleton.ThreadSafety.Singleton s2 = Singleton.ThreadSafety.Singleton.Instance;
    Console.WriteLine("Thread 2");
}
