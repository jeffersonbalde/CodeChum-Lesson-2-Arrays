using System;

public class Program
{

    static string combineChars(char a, char b)
    {
        string combineChar = $"{a}{b}";
        return combineChar;
    }
    
    public static void Main(string[] args)
    {
        
        Console.Write("Enter first character: ");
        char first = Console.ReadLine()[0];

        Console.Write("Enter second character: ");
        char second = Console.ReadLine()[0];

        string result = combineChars(first, second);

        Console.WriteLine(result[0]);
        Console.WriteLine(result[1]);
    }
}