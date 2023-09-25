using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespaces TestDelegate
{
	public delegate void MyDelegate(string msg);
	class Program
	{
		static void Main(string[] args)
		{
			MyDelegate del=ClassA.MethodA;
			del("Hello World!");

			del=ClassB.MethodB;
			del("Hello Italy!");
		}
	}

	class ClassA
	{
		static void MethodA(string message)
		{
			Console.WriteLine("Called ClassA.Method() with parameter: "+message);
		}
	}

	class ClassB
	{
		static void MethodB(string message)
		{
			Console.WriteLine("Called ClassB.Method() with parameter: "+message);
		}
	}
}
