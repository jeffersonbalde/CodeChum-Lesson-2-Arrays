using System;

class Program {
    public static void reverseInt(int num) 
    {
        string numString = num.ToString();

        for(int i = numString.Length - 1; i >= 0; i--)
        {
            Console.Write(numString[i]);
        }
    }

    static void Main(string[] args) 
    {
        Console.Write("Enter an integer: ");
        int input = int.Parse(Console.ReadLine());

        reverseInt(input);
    }
}