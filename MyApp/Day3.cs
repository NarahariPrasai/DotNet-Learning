using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

public class Day3
{
    public void Third()
    {

        //Important Note: Strings are immutable, Arrays are mutable

        //---------------------STRING METHODS---------------------//
        /*
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

        //Creating and accessing 2D array
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
        */
        
    }
}











