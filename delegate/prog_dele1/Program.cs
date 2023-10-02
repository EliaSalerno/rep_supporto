using System;

namespace TestDelegate
{
	class Program
	{
		public delegate void Print(int value);
		static void Main(string[] args)
		{
			Print printDel=printNumber;
			// Print printDel=new Print(printNumber);
			printDel(100000);
			printDel(200);

			printDel=printMoney;
			printDel(100000);
			printDel(200);
			Console.ReadLine();
		}
		public static void printNumber(int num)
		{
			Console.WriteLine("Number: {0,-12:N0}",num);
		}
		public static void printMoney(int money)
		{
			Console.WriteLine("Number: {0:C}",money);
		}
	}
}
