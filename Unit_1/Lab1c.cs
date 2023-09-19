using System;
					
public class Program
{
	public void Main()
	{
		int myNum = 7;
		int i = 1;
		do{
		string number = new string((char) ('0' + i), i);	
		Console.WriteLine(number);
		i++;
		}
		while (i <= myNum);
	}
}	