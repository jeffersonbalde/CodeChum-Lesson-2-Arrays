using System;

class MainClass {

    static public void Main()
    {
        int[ , ] numArray = new int[2, 4] {{1, 2, 3, 4}, {3, 5, 7, 9}};

        // Hey there, start typing your C# code here...
        for(int i = 0; i < numArray.GetLength(0); i++)
        {
            for(int j = 0; j < numArray.GetLength(1); j++)
            {
                if(numArray[i, j] == 4)
                {
                    Console.Write(numArray[i, j] + " ");
                }
                else if(numArray[i, j] == 9)
                {
                    Console.Write(numArray[i, j] + " ");
                }
                else
                {
                    Console.Write(numArray[i, j] + ", ");
                }
            }
            Console.WriteLine();
        }
    }
}