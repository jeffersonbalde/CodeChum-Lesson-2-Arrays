using System;

class MainClass
{
    public static void Main()
    {
        Console.Write("Enter the size of the array: ");
        int size = int.Parse(Console.ReadLine());

        int[] numArray = new int[size];
        
        for(int i = 0; i < numArray.Length; i++)
        {
            Console.Write("Enter element #" + (i + 1) + ": ");
            numArray[i] = int.Parse(Console.ReadLine());
        }

        int value = 0;
        
        for(int i = 0; i < numArray.Length; i++)
        {
            value += numArray[i];
        }

        double average = (double)value / numArray.Length;

        Console.WriteLine($"sum: {value}");
        Console.WriteLine($"average: {average:F2}");
    }
}