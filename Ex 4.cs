using System;
public class Exercise4
{
  public static void Main()
  {
    int number1, number2, number3;
 
    Console.Write("Enter first number - ");  //accept user input
    number1 = Convert.ToInt32(Console.ReadLine());
     
    Console.Write("Enter second number - ");
    number2 = Convert.ToInt32(Console.ReadLine());
 
    Console.Write("Enter third number - ");
    number3 = Convert.ToInt32(Console.ReadLine());
 
    Console.Write("Result of specified numbers {0}, {1} and {2}, (x+y)·z is {3} and x·y + y·z is {4}\n\n",
        number1, number2, number3, ((number1+number2)*number3), (number1*number2+number2*number3));
  }
}
