using System;

public class Program
{
	public static void ageTeller(int age)
	{
		Console.WriteLine("Your age is " + age);
	}

	public static void Main()
	{
		Console.Write("Enter your age: ");
        int age = int.Parse(Console.ReadLine());

        ageTeller(age);
	}
}