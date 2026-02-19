using System;

public class Day2
{
    public void Second()
    {

        /*.............................Even Odd and Divisibility..................
        Console.Write("Enter a number: ");
        string num = Console.ReadLine()!;
        int value = int.Parse(num);
        if (value%2==0)
        {
           Console.WriteLine("The number is even");
        }
        else
        {
            Console.WriteLine("The number is odd.");
        }

        if(value%5==0 && value %3 == 0)
        {
            Console.WriteLine("The number is divisible by both 3 and 5");
        }else if(value%3==0)
        {
            Console.WriteLine("The number is divisibe by 3 but not 5.");
        }
        else if(value%5==0)
        {
            Console.WriteLine("The number is divisible by 5 but not 3");
        }
        else
        {
            Console.WriteLine("The number is not divisible by 3 or 5");
        }
        */


        /*...............................Equal Greater and Between........................
        Console.Write("Enter a number: ");
        string value1 = Console.ReadLine()!;
        Console.Write("Enter second number: ");
        string value2 = Console.ReadLine()!;
        int number1 = int.Parse(value1);
        int number2 = int.Parse(value2);
        int diff = Math.Abs(number1 - number2);

        if(number1 > number2)
        {
            Console.WriteLine(number1 + " is greater");
        }else if(number2 > number1)
        {
            Console.WriteLine(number2 + " is greater");
        }
        else
        {
            Console.WriteLine("Both numbers are equal");
        }

        Console.WriteLine("The difference btween them is " +diff);

        if (number1>=10 && number1<= 100)
        {
            Console.WriteLine("First number is between 10 and 100");
        }
        else
        {
            Console.WriteLine("First number is not between 10 and 100");
        }
        */

        
           
    }
}