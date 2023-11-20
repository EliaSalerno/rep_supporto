using System;
using System.Threading;

namespace ThreadsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
        	Prova prova = new();
        	Thread t= new (prova.SomeMethod!);
            
            t.Start(9);
            
            Console.WriteLine("Press enter to terminate!");
            Console.ReadLine();
        }
	}
	public class Prova{
        public void SomeMethod(object i)
        {
		Console.WriteLine("hello!");
		int? bho= (int) i;
		for(;bho>0;bho--) Console.Write(bho);
		Console.WriteLine();
        Console.WriteLine("Bye bye!");
        }
    }
}

