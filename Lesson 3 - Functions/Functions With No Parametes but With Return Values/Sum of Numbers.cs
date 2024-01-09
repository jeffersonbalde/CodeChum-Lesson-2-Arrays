using System;

class MainClass {

    static float ComputeSumOfNumbers()
    {
        Console.Write("Enter first number: ");
        float a = float.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        float b = float.Parse(Console.ReadLine());
        Console.Write("Enter third number: ");
        float c = float.Parse(Console.ReadLine());

        float result =  a + b + c;
        return result;
    }
    
    static public void Main(string[] args)
    {
        Console.Write(ComputeSumOfNumbers().ToString("F"));
    }
}