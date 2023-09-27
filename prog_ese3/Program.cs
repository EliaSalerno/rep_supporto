using System;

class Program
{
	public delegate double MathDelegate(double value1, double value2);
	public static double Add(double value1,double value2)
	{
		return value1+value2;
	}
	public static double Subtract(double value1,double value2)
	{
		return value1-value2;
	}
	public static void Main(string[] args)
	{
		MathDelegate mathDel=Add;
		var result=mathDel(5,2);
		Console.WriteLine(result);

		mathDel=Subtract;
		result=mathDel(5,2);
		Console.WriteLine(result);

		Console.ReadLine();
	}
}
