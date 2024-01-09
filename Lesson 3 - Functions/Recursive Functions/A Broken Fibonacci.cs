using System;

public class Program
{
    public static int fib(int n)
    {
        if (n <= 1)
        {
            return n;
        }
    
        return fib(n - 1) + fib(n - 2);
    }
     
    public static void Main(string[] args)
    {
        int n;
        
        Console.Write("Enter which nth term: ");
        n = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Nth term = " + fib(n));
    }
}