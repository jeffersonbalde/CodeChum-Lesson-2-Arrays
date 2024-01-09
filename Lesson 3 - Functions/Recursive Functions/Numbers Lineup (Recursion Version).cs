using System;

public class Program
{
    public static void printRecursively(int n)
    {
        if(n == 1)
        {
            Console.Write(n);
        }else 
        {
            Console.Write(n + ", ");
            printRecursively(n - 1);
        }
    }
    
    public static void Main(string[] args)
    {
        int n;
        
        Console.Write("Enter n: ");
        n = Convert.ToInt32(Console.ReadLine());
        
        printRecursively(n);
    }
}