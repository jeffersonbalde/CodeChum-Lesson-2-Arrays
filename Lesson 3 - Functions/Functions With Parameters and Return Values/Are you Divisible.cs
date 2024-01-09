using System;

public class Program
{

    static int isDivisibleBy(int a, int b)
    {
        if(a % b == 0)
        {
            return 1;
        }else 
        {
            return 0;
        }
    }
    
    public static void Main(string[] args)
    {
        
        Console.Write("Enter first number: ");
        int first = int.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        int second = int.Parse(Console.ReadLine());

        int result = isDivisibleBy(first, second);
        if( result == 1)
        {
            Console.WriteLine("yes");
        }else 
        {
            Console.WriteLine("no");
        }
    }
}