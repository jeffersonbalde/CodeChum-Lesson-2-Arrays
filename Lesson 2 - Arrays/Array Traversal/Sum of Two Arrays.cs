using System;

class MainClass
{
    public static void Main()
    {
        Console.Write("Enter the size of the arrays: ");
        int size = int.Parse(Console.ReadLine());

        int[] numArray1 = new int[size];
        int[] numArray2 = new int[size];

        Console.WriteLine("Enter the elements of the first array:");
        for(int i = 0; i < numArray1.Length; i++)
        {
            Console.Write("Enter element #" + (i + 1) + ": ");
            numArray1[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Enter the elements of the second array:");
        for(int i = 0; i < numArray2.Length; i++)
        {
            Console.Write("Enter element #" + (i + 1) + ": ");
            numArray2[i] = int.Parse(Console.ReadLine());
        }
        
        int[] sum = new int[size];

        for(int i = 0; i < numArray1.Length; i++)
        {
            sum[i] = numArray1[i] + numArray2[i];
        }
        
        for(int i = 0; i < numArray1.Length; i++)
        {
            Console.Write($"{numArray1[i]} + {numArray2[i]} = {sum[i]}");
            Console.WriteLine();
        }
    }
}