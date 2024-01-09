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

        Console.Write("Enter a value to search for: ");
        int value = int.Parse(Console.ReadLine());

        bool found = false;
        
        for(int i = 0; i < numArray.Length; i++)
        {
            if(numArray[i] == value)
            {
                found = true;
            }
        }

        if(found)
        {
            Console.WriteLine("Found!");
        }
        else
        {
            Console.WriteLine($"Sorry, {value} not found." );
        }
    }
}