using System;

public class Program
{
	public static int Factorial(int n)
	{
		if (n == 0)
		{
			return 1; 
		}
		else
		{
			return n * Factorial(n - 1); 
		}
	}

	public static void Main()
	{
        Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine());

        int result = Factorial(num);
        Console.WriteLine("Factorial of " + num + ": " + result);
	}
}