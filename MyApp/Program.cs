using System;
using System.IO.Pipelines;

class Program
{
        /* int a;
        int b;
    void add()
    {
        int result = a + b;
        System.Console.WriteLine(result);
    }
    */
    static void Main(string[] args)
    {
        /*Program p1 = new Program();
        p1.a = 20;
        p1.b = 30;
        p1.add();*/

        /*..............Day1.....................
        Basics B1 = new Basics();
        B1.First();
        */

        /*.................Day2................
        Day2 d2 = new Day2();
        d2.Second();*/

        /*..................Day3..............
        Day3 d3 = new Day3();
        d3.Third();
        */

        /*...................Day4..............
        day d4 = new Day4();
        d4.Forth();
        */

        /*.............Constructors...............*/
        Customer c = new Customer(1, "Nischal");
        System.Console.WriteLine(c.Id);
        System.Console.WriteLine(c.Name); 
        



    }
}
