using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDelegate
{

	public delegate void MyDelegate(string msg);
	
	public class Program
	{
		public static void Main(string[] args)
		{
			MyDelegate del=ClassA.MethodA;
			del("Hello World!");

			del=ClassB.MethodB;
			del("Hello Italy!");
		}
	}

	public class ClassA
	{
		public static void MethodA(string message)
		{
			Console.WriteLine("Called ClassA.Method() with parameter: "+message);
		}
	}

	public class ClassB
	{
		public static void MethodB(string message)
		{
			Console.WriteLine("Called ClassB.Method() with parameter: "+message);
		}
	}
}
