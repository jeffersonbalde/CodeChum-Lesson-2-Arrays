using System;

class MainClass
{
    public static void Main()
    {
        Console.Write("Enter the size of the array: ");
        int size = int.Parse(Console.ReadLine());

        int[] numArray = new int[size];
        
        Console.WriteLine("Enter the elements of the array:");
        for(int i = 0; i < numArray.Length; i++)
        {
            Console.Write("Enter element #" + (i + 1) + ": ");
            numArray[i] = int.Parse(Console.ReadLine());
        }

        for(int i = numArray.Length - 1; i >= 0; i--)
        {
            if(i == 0)
            {
                Console.Write(numArray[i]);
            }
            else 
            {
                Console.Write(numArray[i] + ", ");
            }
        }
    }
}