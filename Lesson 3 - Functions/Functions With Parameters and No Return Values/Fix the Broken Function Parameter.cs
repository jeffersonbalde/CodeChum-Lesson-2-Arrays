using System;

class Program {
    public static void printProduct(int a, int b) {
        int product = a * b;
        Console.WriteLine("Product = " + product);
    }

    static void Main(string[] args) {
        Console.Write("Enter x: ");
        int x = int.Parse(Console.ReadLine());
        Console.Write("Enter y: ");
        int y = int.Parse(Console.ReadLine());
        printProduct(x, y);
    }
}