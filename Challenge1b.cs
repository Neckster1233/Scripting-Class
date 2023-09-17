using System;
					
public class Program
{
	public static void Main()
	{
		int temp = 0;
		int score = 78;
		string subject = "science";
		if (temp > 30)
			Console.WriteLine("Remember to hydrate and avoid being in the sun for too long");
	    else if (temp >20)
			Console.WriteLine("Enjoy the nice weather");
		else if (temp >10)
			Console.WriteLine("Be careful of the rain");
		else if (temp >0)
			Console.WriteLine("Take a jacket, it's cold out there!");
		else if (temp <1)
			Console.WriteLine("Make sure to take warm clothes!");
		if (score >= 90)
			Console.WriteLine("Grade: A");
		else if (score >= 80)
			Console.WriteLine("Grade: B");
		else if (score >= 70)
			Console.WriteLine("Grade: C");
		else if (score >= 60)
			Console.WriteLine("Grade: D");
		else if (score < 60)
			Console.WriteLine("Grade: F");
		switch (subject)
		{
			case "math":
			Console.WriteLine("Make sure to keep practing your additions and subtractions!");
				break;
			case "history":
			Console.WriteLine("Read up on your history daily. We never want to repeat the same mistakes!");
				break;
			case "english":
			Console.WriteLine("Make sure to always be reading and writing. You will use it your whole life!");
				break;
			case "P.E.":
			Console.WriteLine("Keep excercising. It's good for you!");
				break;
			case "science":
			Console.WriteLine("Science is how the world works. It is always helpful to know!");
				break;
		}
	}
}