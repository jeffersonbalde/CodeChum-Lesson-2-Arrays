using System;

public class Program
{
	public static void hello()
	{
        for(int i = 0; i < 5; i++)
        {
            Console.WriteLine("Hello CodeChum");
        }
	}

	public static void Main()
	{
		hello();
        hello();
        hello();
	}
}