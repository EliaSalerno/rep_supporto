using System;

internal class Program
{
	static void Hello(string s)
	{
		Console.WriteLine("Hello, {0}!",s);
	}
	static void Goodbye(string s)
	{
		Console.WriteLine("Goodbye, {0}",s);
	}
	delegate void Del(string s);
	static void Main(string[] args)
	{
		Del a, b, c;
		Del? d, k;
		a=Hello;
		b=Goodbye;
		c=a+b;
		k=null;
		k+=a;
		k+=b;
		d=c-a;
		Console.WriteLine("Invoke delegate a: ");
		a("A");
		Console.WriteLine("Invoke delegate b: ");
		b("B");
		Console.WriteLine("Invoke delegate c: ");
		c("C");
		Console.WriteLine("Invoke delegate d: ");
		d("D");
		Console.WriteLine("Invoke delegate k: ");
		k("K");

		Console.WriteLine("Quanti sono i delegati associati a k?");
		int invocationCount=k.GetInvocationList().GetLength(0);
		Console.WriteLine($"Sono esattamente {invocationCount}");
		Console.ReadLine();
	}
}
