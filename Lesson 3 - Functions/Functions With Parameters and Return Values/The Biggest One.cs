using System;

public class Program
{

    static int max(int a, int b, int c)
    {
        if(a >= b && a >= c) { return a;}
        else if(b >= a && b >= c) { return b;}
        else { return c;}
    }
    
    public static void Main(string[] args)
    {
        
        Console.Write("Enter first number: ");
        int first = int.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        int second = int.Parse(Console.ReadLine());

        Console.Write("Enter third number: ");
        int third = int.Parse(Console.ReadLine());
        
        int maxVal = max(first, second, third);

        Console.Write("Maximum Value: " + maxVal);
    }
}