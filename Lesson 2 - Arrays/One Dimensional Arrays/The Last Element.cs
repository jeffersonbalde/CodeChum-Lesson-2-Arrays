using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter array size: ");
        int array_size = int.Parse(Console.ReadLine());

        int[] array = new int[array_size];

        Console.WriteLine("Enter elements of the array: ");

        for(int i = 0; i < array_size; i++)
        {
            int input = int.Parse(Console.ReadLine());
            array[i] = input;
        }

        Console.WriteLine(array[array_size - 1]);
    }
}