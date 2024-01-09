using System;

public class Program
{

    static int getSum(int a, int b)
    {
        return a + b;
    }
    
    public static void Main(string[] args)
    {
        int a, b;
        
        Console.Write("Enter first number: ");
        a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter second number: ");
        b = Convert.ToInt32(Console.ReadLine());
        
        int sum = getSum(a, b);
        
        Console.Write("Sum = " + sum);
    }
}