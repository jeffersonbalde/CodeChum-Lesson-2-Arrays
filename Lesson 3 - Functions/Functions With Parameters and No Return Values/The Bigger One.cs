using System;

class Program {
    public static void max(double a, double b) 
    {
        if(a > b)
        {
            Console.WriteLine(a.ToString("F2"));
        }else 
        {
            Console.WriteLine(b.ToString("F2"));
        }
    }

    static void Main(string[] args) {
        
        Console.Write("Enter first decimal number: ");
        double first = double.Parse(Console.ReadLine());
        
        Console.Write("Enter second decimal number: ");
        double second = double.Parse(Console.ReadLine());
        max(first, second);
    }
}