using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter array size: ");
        int array_size = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter elements of the array: ");

        int[] array = new int[array_size];

        for(int i = 0; i < array_size; i++)
        {
            int input = int.Parse(Console.ReadLine());
            array[i] = input;
        }

        Console.Write("Enter an index: ");
        int index = int.Parse(Console.ReadLine());

        Console.WriteLine(array[index]);
    }
}