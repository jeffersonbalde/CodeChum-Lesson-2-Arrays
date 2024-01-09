using System;

class Program {

    public static void printBreakLine()
    {
        Console.WriteLine();
    }
    
    static public void Main()
    {
        Console.Write("Line 1");
        printBreakLine();
        Console.Write("Line 2");
        printBreakLine();
        Console.Write("Line 3");
        printBreakLine();
    }
}