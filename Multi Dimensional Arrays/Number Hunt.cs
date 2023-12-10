using System;

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

        Console.Write("Enter x: ");
        int x = int.Parse(Console.ReadLine());

        string check = "Sorry, " + x + " not found.";

        for(int i = 0; i < numArray.GetLength(0); i++)
        {
            for(int j = 0; j < numArray.GetLength(1); j++)
            {
                if(numArray[i, j] == x)
                {
                    check = "Found!";
                }
            }
        }

        Console.Write(check);

    }
}