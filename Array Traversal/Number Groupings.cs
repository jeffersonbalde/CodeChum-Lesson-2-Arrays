using System;
using System.Collections.Generic;

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

        // List kay walay fix size gihapon
        List<int> evenNumber = new List<int>();
        List<int> oddNumber = new List<int>();

        for(int i = 0; i < numArray.Length; i++)
        {
            if(numArray[i] % 2 == 0)
            {
                evenNumber.Add(numArray[i]);
            }
            else 
            {
                oddNumber.Add(numArray[i]);
            }
        }

        Console.Write("even: ");
        for(int i = 0; i < evenNumber.Count; i++)
        {
            if(i == evenNumber.Count - 1)
            {
                Console.Write(evenNumber[i]);
            }
            else
            {
                Console.Write(evenNumber[i] + ", ");
            }
        }
        
        Console.Write("\nodd: ");
        for(int i = 0; i < oddNumber.Count; i++)
        {
            if(i == oddNumber.Count - 1)
            {
                Console.Write(oddNumber[i]);
            }
            else
            {
                Console.Write(oddNumber[i] + ", ");
            }
        }
    }
}