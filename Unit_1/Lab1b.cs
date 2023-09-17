using System;
					
public class Program
{
	public static void Main()
	{
		int temp = 45;
		int score = 78;
		if (temp >= 30)
			Console.WriteLine("Remember to hydrate and avoid being in the sun for too long");
	    else
			Console.WriteLine("Enjoy the nice weather");
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
	}
}