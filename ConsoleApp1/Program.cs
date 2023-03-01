using System.Diagnostics;

Method();

void Method()
{
    Thread backgroundThread = new Thread(Method);

    Thread.Sleep(1000);

    backgroundThread.IsBackground = true;

    backgroundThread.Start();

    Console.WriteLine($"Start Thread ID: {backgroundThread.ManagedThreadId}");

    Console.WriteLine($"Thread ID: {backgroundThread.ManagedThreadId}\nThreadsCount= {Process.GetCurrentProcess().Threads.Count}\nThreadState:{Thread.CurrentThread.ThreadState}");

    Console.WriteLine($"Finish Thread ID: {backgroundThread.ManagedThreadId}");

    Thread.CurrentThread.Join();
}