using System;

public class Program
{
	public static void withLowerCase(char input)
	{
        Console.Write(input);
        char toLower = char.ToLower(input);
        Console.WriteLine(toLower);
	}

	public static void Main()
	{
        Console.Write("Enter a character: ");
        char input = Console.ReadLine()[0];

        withLowerCase(input);
	}
}