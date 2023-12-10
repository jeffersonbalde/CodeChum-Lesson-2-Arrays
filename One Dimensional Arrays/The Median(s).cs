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

        if(array_size % 2 != 0)
        {
            int odd = array[array.Length/2];
            Console.WriteLine(odd);
        }
        else
        {
            int even = array[array.Length/2];
            int first = array[array.Length / 2 - 1];
            Console.WriteLine(first + " and " + even);`
        }
    }
}