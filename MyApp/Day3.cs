using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

public class Day3
{
    public void Third()
    {
        //------------------------CHAR METHODS--------------------------//
        /*
        char c = 'x';

        System.Console.WriteLine(char.IsLetter(c)); 

        System.Console.WriteLine(char.IsDigit(c)); 

        System.Console.WriteLine(char.IsLetterOrDigit(c));

        System.Console.WriteLine(char.IsWhiteSpace(c)); 

        System.Console.WriteLine(char.ToUpper(c));

        System.Console.WriteLine(char.ToLower(c));

        System.Console.WriteLine(char.IsUpper(c));

        System.Console.WriteLine(char.IsLower(c));

        System.Console.WriteLine(char.IsPunctuation(c));




        //Important Note: Strings are immutable, Arrays are mutable

        //---------------------STRING METHODS---------------------//
        
        //Converting Char Array into String
        char[] array = {'1', '2', '3', '4', '5'};
        string arraytostring = new string(array);
        System.Console.WriteLine(arraytostring);

        //Length of string
        string name = "BaburaoGaitonde";
        int length = name.Length;
        Console.WriteLine(length);


        //ToUpper and ToLower
        name = name.ToUpper();
        name = name.ToLower();
        System.Console.WriteLine(name);
        

        //Contains
        string name = "BaburaoGaitonde";
        Console.WriteLine(name.Contains('z'));
        bool contains = name.Contains("rao");
        Console.WriteLine(contains);

        //Substring
        string name = "BaburaoGaitonde";
        string slicedname = name.Substring(0,7); // 0->starting index, 7->Length
        Console.WriteLine(slicedname);

        //Replace
        string name = "BaburaoGaitonde";
        string newname = name.Replace("Gaitonde", "Aapte");
        Console.WriteLine(newname);

        //Trim
        string name = "Baburao Aapte";
        Console.WriteLine(name.Trim());

        //IndexOf
        string name = "Baburao Ganpatrao Aapte";
        Console.WriteLine(name.IndexOf('o'));

        //StartsWith and EndsWith
        string name = "Baburao Ganpatrao Aapte";
        Console.WriteLine(name.ToLower().StartsWith('b'));
        Console.WriteLine(name.EndsWith("Aapte"));
        

        //Split
        string sentence = "My name is.Sheela";
        string[] words = sentence.Split(' ', '.');
        foreach ( string word in words)
        {
            Console.WriteLine(word);
        }

        //EqualsTo
        string a = "Babu";
        string b = "babu";
        System.Console.WriteLine(a.Equals(b));
        System.Console.WriteLine(a.Equals(b, StringComparison.OrdinalIgnoreCase));
        

        //Looping through and array
        int[] ages = {10,20,30,40,50,60};
        for(int i=0; i<=5; i++)
        {
           System.Console.WriteLine(ages[i]);
        }
        foreach(int n in ages)
        {
            System.Console.WriteLine(n);
        }

        //Sum of element inside array
        int[] numbers = { 10, 20, 30, 40, 50 };
        int sum = 0;
        foreach(int n in numbers)
        {
            sum+=n;
        }
        Console.WriteLine(sum);


        //Maximum and Minimum Number in an array
        int[] numbers = { 10, 20, 30, 40, 50 };
        int max = numbers[0];
        int min = numbers[4];
        foreach(int n in numbers)
        {
            if (n > max)
            {
                max = n;
            }
            if(n < min)
            {
                min = n;
            }
        }
        Console.WriteLine(max);
        Console.WriteLine(min);
        

        //---------------------ARRAY METHODS-----------------------// 

        //Converting string into character array
        string namaye = "Hareram";
        char[] newchararray = namaye.ToCharArray();
        foreach(char c in newchararray)
        {
            System.Console.WriteLine(c + " ");
        }
        

        //Sorting Array
        int[] numbers = {5, 4, 3, 2, 1};
        Array.Sort(numbers);

        foreach(int n in numbers){
        Console.Write(n + " ");
        }
        

        //Reverse Arryay
        string[] names = {"Hello", "Hi", "Tata", "Bye"};
        Array.Reverse(names);
        foreach( string s in names)
        {
            System.Console.Write(s + " ");
        }


        //IndexOf Array
        string[] names = {"Hello", "Hi", "Tata", "Bye"};
        Console.WriteLine(Array.IndexOf(names, "Tata"));

        
        //Resize Array
        int[] numbers = {5, 4, 3, 2, 1};
        Array.Resize(ref numbers, 7);
        numbers[5] = 0;
        numbers[6] = -1;

        foreach( int n in numbers)
        {
            System.Console.Write(n + " ");
        }


        //Clear Array
        int[] numbers = {5, 4, 3, 2, 1};
        Array.Clear(numbers, 1, 2);
        foreach( int n in numbers)
        {
            System.Console.Write(n + " ");
        }



        //Copy Array
        int[] numbers = {5, 4, 3, 2, 1};
        int[] target = new int[5];
        Array.Copy( numbers, target, numbers.Length); // source, destination and number of elements to copy
        foreach( int t in target)
        {
            System.Console.Write(t + " ");
        }
        


        //Exists Method => Checks if any element matches a condition and returns true or false
        int[] numbers = {5, 4, 3, 2, 1};
        bool hasEven = Array.Exists(numbers, n => n%5 == 0);
        System.Console.WriteLine(hasEven);


        //Find Method => checks condition and returns the matched value
        int[] numbers = {5, 4, 3, 2, 1};
        int value = Array.Find(numbers, n => n%3 == 0);  //Returns first matched value
        Console.WriteLine(value);
        int[] values = Array.FindAll(numbers, n=>n%2==0); //Returns all matched values and stores on array
        foreach(int v in values)
        {
            Console.Write(v + " ");
        }
        


        //------------------------------MULTIDIMENSIONAL ARRAY----------------------------//

        //2D Array Initialization statically
        int [,] numbers = {{1,2,3,4,5}, {6,7,8,9,10}, {11,12,13,14,15}}; 
        System.Console.WriteLine(numbers[1,2]);

        //Looping in 2D array
        for(int i=0; i<=2; i++)
        {
            for(int j=0; j<=4; j++)
            {
                Console.Write(numbers[i,j] + " ");
            }
            System.Console.WriteLine();
        }

         
        //Creating and accessing 3D array 
        int[,,] numbers=
        {
            { 
                {1, 2, 3},{4,5,6}
            },//First Layer
            { 
                {4, 5, 6},{7, 8, 9}
            }//Second Layer
        };
        System.Console.WriteLine(numbers[0,1,1]);

        //Looping in 3D array
        for( int i=0; i<=1; i++)
        {
            for(int j=0; j<=1; j++)
            {
                for(int k=0; k<=2; k++)
                {
                    System.Console.Write(numbers[i,j,k] + " ");
                }
                System.Console.WriteLine();  
            }
            System.Console.WriteLine();
        }
        

        //Jagged Array
        int[][] jaggedarray = new int[3][];
        jaggedarray[0] = new int[] {10, 20, 30};
        jaggedarray[1] = new int[] {40, 50};
        jaggedarray[2] = new int[] {60, 70, 80, 90};

        System.Console.WriteLine(jaggedarray[1][1]);
        
        //Looping Jagged Array
        for( int i=0; i<jaggedarray.Length; i++)
        {
            for( int j=0; j<jaggedarray[i].Length; j++)
            {
                System.Console.Write(jaggedarray[i][j] + " ");
            }
            System.Console.WriteLine();
        }
        


        //================================STRING ANALYZER============================//
        System.Console.Write("Write a sentence: ");
        string input = Console.ReadLine()!;

        //Counting character
        string value = input.Trim().Replace(" ", "");
        int result = value.Length;
        System.Console.WriteLine($"Your sentence have {result} letters.");

        //Counting words
        string[] value1 = input.Trim().Split(" ");
        int result1 = value1.Length;
        System.Console.WriteLine($"Your sentence have {result1} words.");

        //Longest Word
        int max = 0;
        string LongestWord= "";
        foreach(string value3 in value1)
        {
            int Wordlength = value3.Length;
            if( Wordlength > max)
            {
                max = Wordlength;
                LongestWord = value3;
            }

        }
        System.Console.WriteLine($"The longest word on your sentence is {LongestWord}.");

        //Revesing Each Word Individually
        System.Console.Write("The reverse of each words are: ");
        foreach(string value4 in value1)
        {
            string word =  value4;
            char[] chararray = word.ToCharArray();
            Array.Reverse(chararray);
            string reversed = new string(chararray);
            System.Console.Write(reversed + " ");
        }
        System.Console.WriteLine();

        //Counting Vowels
        char[] InputCharArray = input.ToCharArray();
        int count = 0;
        foreach( char c in InputCharArray)
        {
            char lower = char.ToLower(c);
            if( lower == 'a' || lower == 'e' || lower == 'i' || lower == 'o' || lower == 'u')
            {
                count++;
            }
        }
        System.Console.WriteLine($"There are {count} vowels on your sentence.");


        //Removing Duplicate words
        bool isDupli = false;
        for(int i=0; i<value1.Length-1; i++)
        {
            for(int j=1; j<Value1.Length; j++)
                {
                    if(value1[i].Equals(value1[j], StringComparison.OrdinalIgnoreCase))
                        {
                            isDupli = true;
                            break;
                        }
                        System.Console.WriteLine(value[i] + " ");   
                }


        if (!isDupli)
        {
            System.Console.WriteLine(value[] + " ");
        }
        }


        //Converting sentence to TitleCase
        System.Console.WriteLine("The titlecase of this sentence is: ");
        foreach(string value6 in value1)
        {
            string newdata = value6;
            char[] newchararray = newdata.ToCharArray();
            newchararray[0] = char.ToUpper(newchararray[0]);
            string lastvalue = new string(newchararray);
            System.Console.Write(lastvalue + " ");
            
        }
        

        //=======================TASK 1 - SUM, AVERAGE AND LARGEST IN 2D ARRAY==============================//
        int sum = 0;
        int max = 0;
        int largest = 0;
        int[,] numbers = new int[3,3];
        for(int i=0; i<numbers.GetLength(0); i++)
        {
            for(int j=0; j<numbers.GetLength(1); j++)
            {
                System.Console.WriteLine($"Enter value for index [{i},{j}]: ");
                int value = int.Parse(Console.ReadLine()!);
                numbers[i,j]= value;
                sum += value;

                if(max < value)
                {
                    largest = value;
                    max = value;
                }
            }
        }
        System.Console.WriteLine($"The sum of all elements is {sum}");
        int average = sum/9;
        System.Console.WriteLine($"The average of all elements is {average}");
        System.Console.WriteLine($"The largest element is {largest}");


        //===================================TASK 2- COLUM AND ROW OPERATIONS IN 2D ARRAY==================//
        int k = 0;
        int j;
        int highest = 0;
        int sum = 0;
        int[,]numbers = new int[3,4];
        for(int i=0; i<numbers.GetLength(0); i++)
        {
            for( j=0; j<numbers.GetLength(1); j++)
            {
                System.Console.Write($"Enter the value of index[{i},{j}]: ");
                int value = int.Parse(Console.ReadLine()!);
                numbers[i,j] = value;
                sum += value;
            }
            System.Console.WriteLine($"The sum of row {i} is {sum}");
            if (sum > highest)
            {
                highest = sum;
                k = i;
            }
            sum = 0;
        }
        System.Console.WriteLine($"The row with highest total is {k}.");

        int answer = 0;
        int colsum = 0;
        int b = 0;
        int c = 0;
        int veryhigh = 0;
        for(int a=0; a<numbers.GetLength(1); a++)
        {
            for(b=0; b<numbers.GetLength(0); b++)
            {
                answer = numbers[b,a];
                colsum += answer;
            }
            System.Console.WriteLine($"The sum of culumn {a} is {colsum}.");
            if(colsum > veryhigh)
            {
                veryhigh = colsum;
                c = a;
            }
            colsum = 0;
        }
        System.Console.WriteLine($"The column with highest total is {c}.");
        

        //========================TASK 3- TRANSPOSE OF MATRIX=====================//
        int[,] numbers = new int[3,3];
        int[,] transpose = new int[3,3];
        for(int i=0; i<numbers.GetLength(0); i++)
        {
            for(int j=0; j<numbers.GetLength(1); j++)
            {
                System.Console.Write($"Enter value for index[{i},{j}]: ");
                int value = int.Parse(Console.ReadLine()!);
                numbers[i,j] = value;
            }
        }

        System.Console.WriteLine("The transpose of this matrix is: ");
        for(int i=0; i<transpose.GetLength(0); i++)
        {
            for( int j=0; j<transpose.GetLength(1); j++)
            {
                transpose[i,j] = numbers[j,i];
                System.Console.Write(transpose[i,j] + " ");
            }
            System.Console.WriteLine();
        }
        

        //=========================TASK 4 - STUDENTS RECORD SYSTEM=====================//
        int LargestStudentAvg = 0;
        int topclass = 0;
        int topstd = 0;
        int sum1 = 0;
        int sum2 = 0;
        int marks = 0;
        int[,,] Schsystem = new int[2, 3, 4];
        for(int i=0; i<Schsystem.GetLength(0); i++)
        {
            for(int j=0; j<Schsystem.GetLength(1); j++)
            {
                for(int k=0; k<Schsystem.GetLength(2); k++)
                {
                    System.Console.Write($"Enter marks of subject {k} for student {j} of class {i}: ");
                    marks = int.Parse(Console.ReadLine()!);
                    Schsystem[i, j, k] = marks;
                    sum1 += marks;
                }
                System.Console.WriteLine($"The average marks of student {j} is {sum1/Schsystem.GetLength(2)}");
                if(sum1 > LargestStudentAvg)
                {
                    LargestStudentAvg = sum1;
                    topstd = j;
                    topclass = i;
                }
                sum2 += sum1;
                sum1 = 0;
            }
            int avg = Schsystem.GetLength(1) * Schsystem.GetLength(2);
            System.Console.WriteLine($"The average marks of class {i} is {sum2/avg}");
            avg = 0;
            sum2 = 0;
        }
        System.Console.WriteLine($"The Topper of School is Student {topstd} of Class {topclass} ");
        */

        
    }

}










