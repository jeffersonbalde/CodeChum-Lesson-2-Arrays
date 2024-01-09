using System;

public class Program
{
    public static int computeSum(int n)
    {
        if (n != 0)
        {        
            return n + computeSum(n - 1);
        }
        else
        {
            return n;
        }
    }
    
    public static void Main(string[] args)
    {
        int n;
        
        Console.Write("Enter n: ");
        n = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Sum = " + computeSum(n));
    }
}