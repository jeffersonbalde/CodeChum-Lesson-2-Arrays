using System;

class Program {

    public static string combineChars() 
    {
        Console.Write("Enter first character: ");
        char first_char = Console.ReadLine()[0];

        Console.Write("Enter second character: ");
        char second_char = Console.ReadLine()[0];

        return $"{first_char}{second_char}";
    }
    
    static void Main(string[] args)
    {
        string result = combineChars();
        Console.WriteLine(result);
    }
}