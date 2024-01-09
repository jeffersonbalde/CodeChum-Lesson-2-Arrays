using System;

class Program {

    public static int addTen() 
    {
        Console.Write("Enter an integer: ");
        int n = int.Parse(Console.ReadLine());

        int result = n + 10;

        return result;
    }
    
    static void Main(string[] args)
    {
        Console.WriteLine(addTen());
    }
}