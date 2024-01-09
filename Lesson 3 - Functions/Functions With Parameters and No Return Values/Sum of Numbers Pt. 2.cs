using System;

public class Program
{
	public static void sumOfIntegers(int a, int b, int c)
	{
        int sum = a + b + c;
		Console.WriteLine(sum);
	}

	public static void Main()
	{
        Console.Write("Enter first integer: ");
        int first = int.Parse(Console.ReadLine());

        Console.Write("Enter second integer: ");
        int second = int.Parse(Console.ReadLine());

        Console.Write("Enter third integer: ");
        int third = int.Parse(Console.ReadLine());

        sumOfIntegers(first, second, third);
	}
}