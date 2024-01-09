using System;

public class Program
{
    public static void printCodeChum(int n)
    {
        if (n != 0)
        {
            Console.WriteLine("CodeChum");
            printCodeChum(n - 1);
        }
    }
    
    public static void Main(string[] args)
    {
        int n;
        
        Console.Write("Enter n: ");
        n = Convert.ToInt32(Console.ReadLine());
        
        printCodeChum(n);
    }   
}