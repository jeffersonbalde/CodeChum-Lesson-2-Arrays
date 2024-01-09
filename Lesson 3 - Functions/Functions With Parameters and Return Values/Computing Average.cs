using System;

public class Program
{

    static double average(int[] array)
    {
        double sum = 0;

        foreach(int num in array)
        {
            sum += num;
        }

        double result = sum / array.Length; 
        return result;
    }
    
    public static void Main(string[] args)
    {
        
        Console.Write("Enter size of array: ");
        int size = int.Parse(Console.ReadLine());

        Console.Write("Enter the numbers: ");
        string[] num = Console.ReadLine().Split(' ');

        int[] numbers = new int[size];
        
        for (int i = 0; i < size; i++)
        {
            numbers[i] = int.Parse(num[i]);
        }

        double result = average(numbers);

        Console.WriteLine("Average: " + result.ToString("F2"));
    }
}