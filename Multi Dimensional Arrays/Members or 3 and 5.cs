using System;
using System.Collections.Generic;

class MainClass {
    static public void Main()
    {
        
        Console.Write("Enter number of rows: ");
        int rows = int.Parse(Console.ReadLine());

        Console.Write("Enter number of columns: ");
        int columns = int.Parse(Console.ReadLine());

        int[,] numArray = new int[rows, columns];

        for(int i = 0; i < numArray.GetLength(0); i++)
        {
            for(int j = 0; j < numArray.GetLength(1); j++)
            {
                Console.Write("Enter element at row " + i + ", column " + j + ": ");
                numArray[i, j] = int.Parse(Console.ReadLine());
            }
        }

        // List kay walay fix size
        List<int> divisibleBy3 = new List<int>();
        List<int> divisibleBy5 = new List<int>();

        for(int i = 0; i < numArray.GetLength(0); i++)
        {
            for(int j = 0; j < numArray.GetLength(1); j++)
            {
                if(numArray[i, j] % 3 == 0)
                {
                    divisibleBy3.Add(numArray[i, j]);
                }
            }
        }

        for(int i = 0; i < numArray.GetLength(0); i++)
        {
            for(int j = 0; j < numArray.GetLength(1); j++)
            {
                if(numArray[i, j] % 5 == 0)
                {
                    divisibleBy5.Add(numArray[i, j]);
                }
            }
        }

        Console.Write("Divisible by 3: ");
        for(int i = 0; i < divisibleBy3.Count; i++)
        {
            if(i == divisibleBy3.Count - 1)
            {
                Console.Write(divisibleBy3[i]);
            }
            else 
            {
                Console.Write(divisibleBy3[i] + ", ");
            }
        }

        Console.WriteLine();
        Console.Write("Divisible by 5: ");
        for(int i = 0; i < divisibleBy5.Count; i++)
        {
            if(i == divisibleBy5.Count - 1)
            {
                Console.Write(divisibleBy5[i]);
            }
            else 
            {
                Console.Write(divisibleBy5[i] + ", ");
            }
        }
    }
}