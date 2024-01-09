using System;

class MainClass {

    static public void Main()
    {
        float[] numArr = {3.14f, 9.2f, 8.812f, 10.5f, 0.4f, -23.23f, -1.56f, 12.3f, 9.45f, -0.968f};

        // Hey there, start typing your C# code here...
        float total =  numArr[0] * numArr[4];

        Console.WriteLine(total.ToString("0.00"));
    }
}