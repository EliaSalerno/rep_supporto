 using System;
using System.Threading;

namespace StopThread
{
    namespace StopThread
    {
        class Program
        {
            
            private static volatile bool _cancel = true;
            public static void Main()
            {
                Thread t = new Thread(Speak!);
                t.Start("Hello World!");
                Thread.Sleep(5000);
                _cancel = false;
                t.Join();
                Console.WriteLine("\nSono il main thread, ho aspettato per 5 secondi che l'altro thread si divertisse a scrivere \"Hello World\", ma ora esco!");
                Console.ReadLine();
            }

            private static void Speak(object s)
            {
                while (_cancel)
                {
                    string? say = s as string;
                    Console.WriteLine(say);
                }
            }
        }
    }
}

