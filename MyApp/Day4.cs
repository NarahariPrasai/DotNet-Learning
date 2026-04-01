using System;
using System.Security.AccessControl;


 /*public class Day4{
    int num1;
    int num2;
    void multiply()
    {
        int result = num1 * num2;
        System.Console.WriteLine(result);
    }
    public void Forth()
    {
        num1 = 10;
        num2 = 10;
        multiply();
    }
}*/

public class Customer
{
    public int Id = 0
    
    ;


    public string Name = "unknown";

    public Customer()
    {
        System.Console.WriteLine(Id);
        System.Console.WriteLine(Name);
    }

    public Customer(int id)
    {
        this.Id = id;
        this.Name = "Unknown";
        System.Console.WriteLine(Id);
    }
    public Customer(int id, string name)
    {
        this.Id = id;
        this.Name = name;
        System.Console.WriteLine(Id);
        System.Console.WriteLine(Name);
    }
}

