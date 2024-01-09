using System;

class MainClass {

    static int[] getIntegers()
    {
        Console.Write("Enter first integer: ");
        int first = int.Parse(Console.ReadLine());

        Console.Write("Enter second integer: ");
        int second = int.Parse(Console.ReadLine());

        Console.Write("Enter third integer: ");
        int third = int.Parse(Console.ReadLine());

        int[] result = new int[] {first, second, third};

        return result;
    }
    
    static public void Main(string[] args)
    {
        int[] mainResult = getIntegers();
        Console.Write(string.Join(", ", mainResult));
    }
}