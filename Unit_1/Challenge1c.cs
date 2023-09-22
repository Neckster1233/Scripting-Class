using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Please input a number 1-10.");
		int myGuess = 8;
		int myNum = 7;
		switch (myGuess)
		{
			case myGuess == myNum:
				Console.WriteLine("Congrats you found the correct number!");
				break;
			case myGuess < myNum:
				Console.WriteLine("The number is higher than that.");
				break;
			case myGuess > myNum:
				Console.WriteLine("The number is lower than that.");
				break;
		}
		Console.WriteLine("Please enter your 3 favorite foods.");
		string [] myFavs = {"Steak", "Potatoes", "Bacon"};
		for (int i = 0; i < myFavs.Lengths; i++)
		{
			Console.WriteLine(myFavs[i]);
		}
	}
}