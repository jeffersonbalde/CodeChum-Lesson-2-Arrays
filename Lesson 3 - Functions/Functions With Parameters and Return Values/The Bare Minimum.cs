using System;

public class Program
{

    static float min(float a, float b, float c)
    {
        if(a < b && a < c) { return a;}
        else if(b < a && b < c) { return b;}
        else { return c;}
    }
    
    public static void Main(string[] args)
    {
        
        Console.Write("Enter first value: ");
        float first = float.Parse(Console.ReadLine());

        Console.Write("Enter second value: ");
        float second = float.Parse(Console.ReadLine());

        Console.Write("Enter third value: ");
        float third = float.Parse(Console.ReadLine());

        double result = min(first, second, third);
        
        Console.WriteLine("Minimum Value: " + result.ToString("F3"));
    }
}