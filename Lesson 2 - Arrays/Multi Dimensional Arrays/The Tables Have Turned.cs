using System;

class MainClass{
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

        for(int i = 0; i < numArray.GetLength(0); i++)
        {
            for(int j = 0; j < numArray.GetLength(1); j++)
            {
                Console.Write(numArray[i, j] + " ");
                break;
            }
        }

        Console.WriteLine();
        for(int i = 0; i < numArray.GetLength(0); i++)
        {
            for(int j = 1; j < numArray.GetLength(1); j++)
            {
                Console.Write(numArray[i, j] + " ");
                break;
            }
        }

        Console.WriteLine();
        for(int i = 0; i < numArray.GetLength(0); i++)
        {
            for(int j = 2; j < numArray.GetLength(1); j++)
            {
                Console.Write(numArray[i, j] + " ");
                break;
            }
        }

        Console.WriteLine();
        for(int i = 0; i < numArray.GetLength(0); i++)
        {
            for(int j = 3; j < numArray.GetLength(1); j++)
            {
                Console.Write(numArray[i, j] + " ");
                break;
            }
        }

        Console.WriteLine();
        for(int i = 0; i < numArray.GetLength(0); i++)
        {
            for(int j = 4; j < numArray.GetLength(1); j++)
            {
                Console.Write(numArray[i, j] + " ");
                break;
            }
        }

        Console.WriteLine();
        for(int i = 0; i < numArray.GetLength(0); i++)
        {
            for(int j = 5; j < numArray.GetLength(1); j++)
            {
                Console.Write(numArray[i, j] + " ");
                break;
            }
        }

        // single loop
        // for (int j = 0; j < numArray.GetLength(1); j++)
        // {
        //     for (int i = 0; i < numArray.GetLength(0); i++)
        //     {
        //         Console.Write(numArray[i, j] + " ");
        //     }
        //     Console.WriteLine();
        // }
    }
}