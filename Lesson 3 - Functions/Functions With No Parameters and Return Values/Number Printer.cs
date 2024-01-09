using System;

public class Program
{
	public static void printNumbers()
	{
		Console.Write("Enter an integer: ");
        int n = int.Parse(Console.ReadLine());

        for(int i = 1; i <= n; i++)
        {
            if(i == n)
            {
                Console.Write(i);
            }else 
            {
                Console.Write(i + ", ");
            }
        }
	}

	public static void Main()
	{
		printNumbers();
	}
}