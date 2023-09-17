using System;

namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {
      int myNum = 24;
      int myNum2 = 8;
      float myNum3 = 11.8F;
      string name = "Enoch";
      string greeting = "Hi there!";
      string ending = "Goodbye";
      char letter = 'A';
      Console.WriteLine(greeting + " " + "My name is " + name + ".");
      int myNum4 = myNum + myNum2;
      Console.WriteLine("The sum of 24 and 8 is " + myNum4);
      float myNum5 = (myNum / myNum3);
      Console.WriteLine("The quotient of 24 and 11.8 is " + myNum5);
      Console.WriteLine(ending);
    }
  }
}