using System;
using System.Data.Common;
using System.Diagnostics;
using System.IO.Pipelines;
using System.Xml.Serialization;

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


        /*..................................Multiplication Table...........................
        string choice;
        do{
        int num;
        Console.WriteLine("Enter a number:");
        if(!int.TryParse(Console.ReadLine()!, out num))
        {
            Console.Write("Invalid input!. Enter a valid number.");
            continue;
        }
        int value;
        for(int i = 1; i<=10; i++)
        {
            value = num * i;
            Console.WriteLine($"{num} x {i} = {value}");
        }

        Console.Write("Do you want to continue(yes/no): ");
        choice = Console.ReadLine()!.ToLower();

        }while(choice == "yes");*/


        /*.......................................Prime Number Checker........................
        int num;
        bool isPrime = true;
        Console.Write("Enter a number: ");
        if(!int.TryParse(Console.ReadLine()!, out num))
        {
            Console.WriteLine("Invalid Number!");
            return;
        }
        if(num < 2)
        {
            isPrime = false;
        }
        for(int i = 2; i<=num/2; i++)
        {
            if(num%i == 0)
            {
                isPrime = false;
                break;
            }
        }
        if (isPrime)
        {
            Console.WriteLine("The number is Prime");
        }
        else
        {
            Console.WriteLine("The number is not prime.");
        }
    }
}*/

        /*..............................Number Guessing Game....................

                Random randoom = new Random();
                int hidden_num = randoom.Next(1,11);
                int guess;

                do{
                Console.Write("Guess a number between 1 to 10: ");
                if(!int.TryParse(Console.ReadLine()!, out guess))
                {
                    Console.WriteLine("Invalid number! Enter again");
                    continue;
                }

                    if (guess > hidden_num)
                    {
                        Console.WriteLine("Too high.");
                    }
                    else if (guess < hidden_num)
                    {
                        Console.WriteLine("Too Low.");
                    }
                    else
                    {
                        Console.WriteLine("Correct Guess!");
                    }
                }while( guess != hidden_num);*/


        /*................................Console Mini Utility Hub.............................*/

        do
        {
            
            Console.WriteLine("-----------------------SMART NUMBER TOOLKIT-------------------------");
            Console.WriteLine();
            Console.WriteLine("1.Even or Odd checker");
            Console.WriteLine("2.Multiplication Table");
            Console.WriteLine("3.Prime Number Checker");
            Console.WriteLine("4.Number Guessing Game");
            Console.WriteLine("5.Simple Calculator");
            Console.WriteLine("6.Exit");
            Console.WriteLine();
            Console.Write("Choose an option: ");
            int pick;
            if(!int.TryParse(Console.ReadLine()!, out pick))
            {
                Console.WriteLine("Invalid Input! Select a number again.");
                continue;
            }

            switch (pick) {
                case 1 : EvenOddChecker();
                         break;

                case 2 : MultiplicationTable();
                         break;

                case 3 : PrimeChecker();
                         break;

                case 4 : NumberGuessing();
                         break;

                case 5 : SimpleCalculator();
                         break;
                
                case 6 : return;

                default: Console.WriteLine("Selected input Out of Bounds.");
                         continue;

            }
        } while(true);

        static void EvenOddChecker()
{
                string choice1 = "";
                Console.WriteLine("...................Even or Odd Checker......................");
                do{
                    Console.WriteLine();
                    Console.Write("Enter a number: ");
                    int num;
                    if(!int.TryParse(Console.ReadLine()!, out num))
                    {
                        Console.WriteLine("Invalid input! Try again");
                        continue;
                    }
                    if ( num%2 == 0)
                    {
                        Console.WriteLine("The number is even");
                    }
                    else
                    {
                        Console.WriteLine("The number is odd");
                    }

                    if (num % 3 == 0 && num% 5 == 0)
                    {
                         Console.WriteLine("The number is divisible by both 3 and 5");
                    }
                    else if (num % 3 == 0)
                    {
                        Console.WriteLine("The number is divisible by 3 but not 5");
                    }
                    else if (num % 5 == 0)
                    {
                        Console.WriteLine("The number is not divisible by 5 but not 3");
                    }
                    else
                    {
                        Console.WriteLine("The number is not divisible 3 and 5");
                    }
                    Console.Write("Do you want to continue?(yes/No): ");
                    choice1 = Console.ReadLine()!.ToLower();

                }while( choice1 != "no");
}

static void NumberGuessing()
{
                    Random random = new Random();
                    int random_number = random.Next(1,10);
                    int num;
                    Console.WriteLine(".......................NUMBER GUESSING GAME........................");
                do{
                    Console.WriteLine();
                    Console.Write("Enter a number: ");
                    if(!int.TryParse(Console.ReadLine()!, out num))
                    {
                    Console.WriteLine("Invalid Input! Select a number again.");
                    continue;
                    }
                        if (random_number > num)
                        {
                            Console.WriteLine("Too Low");
                        }
                        else if (random_number < num)
                        {
                            Console.WriteLine("Too high");
                        }
                        else
                        {
                            Console.WriteLine("Correct Guess");
                        }
                }while(random_number != num);
}

static void SimpleCalculator()
{
                string choice4 = "";
                Console.WriteLine("...................SIMPLE CALCULATOR......................");
                do{
                    Console.WriteLine();
                    Console.Write("Enter a number: ");
                    int num1;
                    if(!int.TryParse(Console.ReadLine()!, out num1))
                    {
                        Console.WriteLine("Invalid input! Try again");
                        continue;
                    }
                    Console.Write("Enter second number: ");
                    int num2;
                    if(!int.TryParse(Console.ReadLine()!, out num2))
                    {
                        Console.WriteLine("Invalid input! Try again");
                        continue;
                    }

                    Console.Write("Select an Operator(+, x, -, /): ");
                    string op = Console.ReadLine()!;
                    int result;
                    if(op == "+")
                        {
                            result = num1 + num2;
                        }
                        else if(op == "x"){
                            result = num1 * num2;
                        }
                        else if(op == "-")
                        {
                            result = num1 - num2;
                        }
                        else if(op == "/")
                        {
                            result = num1 / num2;
                        }
                        else
                        {
                            Console.WriteLine("Invalid Operator");
                            continue;
                        }

                        Console.WriteLine("Result of this operation is " + result);
                    Console.Write("Do you want to continue?(yes/No): ");
                    choice4 = Console.ReadLine()!.ToLower();

                }while( choice4 != "no");
}

static void PrimeChecker()
{
                    string choice3 = "";
                    Console.WriteLine("..................................PRIME NUMBER CHECKER........................");
                do{
                    Console.WriteLine();
                    Console.Write("Enter a number: ");
                    int num;
                    if(!int.TryParse(Console.ReadLine()!, out num))
                    {
                    Console.WriteLine("Invalid Input! Select a number again.");
                    continue;
                    }
                    bool isPrime = true;

                    if (num < 2)
                        {
                            Console.WriteLine("The number is not prime");
                        }
                    for(int i=2; i<=num/2; i++)
                        {
                            if (num % i == 0)
                            {
                                isPrime = false;
                            }
                        }
                    
                    if(isPrime)
                        {
                            Console.WriteLine("The number is prime");
                        }
                        else
                        {
                            Console.WriteLine("The number is not prime");
                        }

                    Console.Write("Do you want to continue?(yes/No): ");
                    choice3 = Console.ReadLine()!.ToLower();
                }while(choice3 != "no");
}

static void MultiplicationTable()
{
                string choice2 = "";
                Console.WriteLine("..................................MULTIPLICATION TABLE........................");
                do{
                    Console.WriteLine();
                    Console.Write("Enter a number: ");
                    int num;
                    if(!int.TryParse(Console.ReadLine()!, out num))
                    {
                    Console.WriteLine("Invalid Input! Select a number again.");
                    continue;
                    }
                    int value;
                    for(int i = 1; i<=10; i++)
                    {
                        value = i * num;
                        Console.WriteLine($"{num} x {i} = {value}");
                    }
                    Console.Write("Do you want to continue?(yes/No): ");
                    choice2 = Console.ReadLine()!.ToLower();
                }while(choice2 != "no");
}

    }
}
