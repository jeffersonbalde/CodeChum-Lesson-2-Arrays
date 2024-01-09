using System;

class MainClass {
    public static void printHelloWorld() {
        Console.WriteLine("Hello World");
    }
    
    static public void Main()
    {
        Console.Write("Enter an integer: ");
        int n = int.Parse(Console.ReadLine());

        for(int i = 1; i <= n; i++)
        {
            printHelloWorld();
        }
    }
}