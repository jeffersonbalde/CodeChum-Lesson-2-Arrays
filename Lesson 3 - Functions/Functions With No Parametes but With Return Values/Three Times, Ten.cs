using System;

class MainClass {

    static int return10()
    {
        return 10;
    }
    
    static public void Main(string[] args)
    {
        int total = 0;
        
        for(int i = 0; i < 3; i++)
        {
            total += return10();
        }

        Console.Write("Total: " + total);
    }
}