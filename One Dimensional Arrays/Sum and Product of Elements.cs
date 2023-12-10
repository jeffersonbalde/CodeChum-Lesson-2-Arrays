using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter size of the first array: ");
        int first_size = int.Parse(Console.ReadLine());
        int[] first_array = new int[first_size];

        Console.WriteLine("Enter elements of the first array: ");

        for(int i = 0; i < first_size; i++)
        {
            int input = int.Parse(Console.ReadLine());
            first_array[i] = input;
        }

        Console.Write("Enter size of the second array: ");
        int second_size = int.Parse(Console.ReadLine());
        int[] second_array = new int[second_size];

        Console.WriteLine("Enter elements of the second array: ");

        for(int i = 0; i < second_size; i++)
        {
            int input = int.Parse(Console.ReadLine());
            second_array[i] = input;
        }

        int sum = first_array[0] + second_array[second_size - 1];
        int product = first_array[1] * second_array[second_size - 2];

        Console.WriteLine("sum of first and last: " + sum);
        Console.WriteLine("product of second and second to the last: " + product);

    }
}