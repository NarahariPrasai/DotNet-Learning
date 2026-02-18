using System;
using System.IO.Pipelines;

public class Basics
{
    public void First()
    {
       /* Console.WriteLine("Nischal Prasai");
        Console.WriteLine(21);
        Console.WriteLine("Hello Namaste");

        int age = 21;
        double amount = 250.99;
        string name = "Nischal";

        Console.WriteLine(age);
        Console.WriteLine(amount);
        Console.WriteLine(name);

        Console.WriteLine("What is your favourite color?");
        string favcolor = Console.ReadLine()!;
        Console.WriteLine("Your Favourite color is " + favcolor);

        const int year = 2026;
        Console.WriteLine("The year is "+year);*/

        //Question 2

        /*Console.Write("Enter a number: ");
        string number1 = Console.ReadLine()!;  // !says that userinput will not be null.
        int firstinput = int.Parse(number1);   //parse converts string into int.
        Console.Write("Enter second number:");
        string number2 = Console.ReadLine()!;
        int secondinput = int.Parse(number2);
        int result = firstinput + secondinput;
        Console.WriteLine("The sum of your two inputs are "+result);

        //Question 3
        double amount = 250.99;
        int newamount = (int)amount;
        float amount2 = 250.985f;
        int newamount2 = (int)amount2;
        Console.WriteLine(newamount);
        Console.WriteLine(newamount2);

        //Question 4
        Console.WriteLine("Enter a decimal number:");
        string userinput = Console.ReadLine()!;
        double value = Convert.ToDouble(userinput);
        Console.WriteLine("The input is "+value);

        //Question 5
        Console.Write("Enter a number: ");
        string value1 = Console.ReadLine()!;
        int newnum;
        bool success = int.TryParse(value1, out newnum);
        if (success)
        {
            Console.WriteLine(newnum);
        }
        else
        {
            Console.WriteLine("Invalid number");
        }*/


        Console.WriteLine(".....................SIMPLE CALCULATOR........................");
        Console.Write("Enter a number:");
        string value = Console.ReadLine()!;
        double num1;
        if(!double.TryParse(value, out num1))
        {
            Console.WriteLine("Error: Invalid Number Format!");
            return;
        }

        Console.Write("Enter a number:");
        string value2 = Console.ReadLine()!;
        double num2;
        if(!double.TryParse(value2, out num2))
        {
            Console.WriteLine("Error: Invalid Number Format!");
            return;
        }

        Console.Write("Select an operation( +, -, /, * ):");
        string op = Console.ReadLine()!;
        double result;
        if(op == "+")
        {
            result = num1 + num2;
        }else if(op == "-")
        {
            result = num1 - num2;
        }else if(op == "*")
        {
            result = num1 * num2;
        }else if ( op == "/")
        {
            if(num2 == 0)
            {
                Console.WriteLine("Error: Number can't be divided by zero.");
                return;
            }
            else
            {
                result = num1/num2;
            }
        }
        else
        {
            Console.WriteLine("Invalid Operation.");
            return;
        }

        Console.WriteLine("The result of operation is: "+ result);
        
    }
}