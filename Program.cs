using System;

namespace ConsoleApp1
{
     public class Program
    {
        static void Main()
        {

        //obligatory greeting to world
        Console.WriteLine("Hello World!");
        Console.WriteLine("");

        Console.WriteLine("What's your name?");
        var person = new Person();
        person.Name = Console.ReadLine();
        person.Introduce();

        Console.Clear();

        #region OrderofOperations
        //region allows me to create collapsible areas of code that I don't need to look at, and don't expect anyone to need to use
        //or maintain.

        //declare some vars with default numbers
        float a = 15f;
        float b = 3f;

        Console.WriteLine("::::: Order of Operations :::::");
        Console.WriteLine("Let's start by getting some numbers to work with.");

        try
        {
            Console.WriteLine("a = ");
            a = Convert.ToSingle(Console.ReadLine());
        }
        catch (Exception)
        {
            Console.WriteLine("Input was not a number, a has been set to " + a);
        }

        try
        {
            Console.WriteLine("b = ");
            b = Convert.ToSingle(Console.ReadLine());
        }
        catch (Exception)
        {
            Console.WriteLine("Input was not a number, b has been set to " + b);
        }

        float c = a / b;
        float d = a / b * b;
        float e = (a / b) * b;
        float f = a / (b * b);

        Console.WriteLine("");
        Console.WriteLine("a = " + a);
        Console.WriteLine("b = " + b);
        Console.WriteLine("");
        Console.WriteLine("We are going to ask C# to return the following: " + a + " / " + b + " * " + b);
        Console.WriteLine("We will see whether C# prioritises multiplication over the division, and performs b*b first (" + (b*b) + ") or whether the division a/b is performed first (" + a/b + ").");
        System.Threading.Thread.Sleep(7000);
        
        Console.WriteLine("Solution: " + a + " / " + b + " * " + b + " = " + d);
        Console.Beep();
        Console.WriteLine("");

        if (d == e)
        {
            Console.WriteLine("We can see that C# prioritises division, which is why 10 / 3 * 3 = " + e +
                                  ". Otherwise, the solution would be " + f + ".");
            Console.WriteLine("");
            Console.WriteLine("C# has prioritised the operators in the order they were written in. This would not be true if instead of / we had asked for the solution to '10 - 3 * 3'; C# will prioritise multiplication and division over addition and subtraction, otherwise it will take the operators in order.");
            System.Threading.Thread.Sleep(5000);
            Console.WriteLine("Let's see that in action:"); float g = a - b * b;
            Console.WriteLine("");
            Console.WriteLine("Solution: " + a + " - " + b + " * " + b + " = " + g);
            Console.Beep();
        }
        else
        {
            Console.WriteLine("We can see that without brackets, the multiplication will always be done first. Otherwise, the result would have been " + e);
        }

        #endregion

        Console.WriteLine("");
        Console.WriteLine("mapgie ©2019");
        Console.WriteLine("");
        Console.WriteLine("Press any key to exit.");
        Console.ReadKey(true);
            
        }
    }
}
