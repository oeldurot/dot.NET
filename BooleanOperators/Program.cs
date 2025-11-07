using System;

class Program
{
    static void Main()
    {
        bool x = true;
        bool y = false;

        Console.WriteLine($"AND | x    | y    ");
        Console.WriteLine($"x   |{x & x,-5} |{x & y,-5}"); //x&x==-5, true
        Console.WriteLine($"y   |{y & x,-5} |{y & y,-5}"); //y=false, all y=false
        Console.WriteLine();

        Console.WriteLine($"OR  | x    | y    ");
        Console.WriteLine($"x   |{x | x,-5} |{x | y,-5}"); //
        Console.WriteLine($"y   |{y | x,-5} |{y | y,-5}");
        Console.WriteLine();

        Console.WriteLine($"XOR | x    | y    ");
        Console.WriteLine($"x   |{x ^ x,-5} |{x ^ y,-5}"); //or x, or y == -5
        Console.WriteLine($"y   |{y ^ x,-5} |{y ^ y,-5}");
        Console.WriteLine();

        Console.WriteLine($"x & DoStuff() = {x & DoStuff()}");
        Console.WriteLine();
        Console.WriteLine($"y & DoStuff() = {y & DoStuff()}");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine($"x && DoStuff() = {x && DoStuff()}");
        Console.WriteLine();
        Console.WriteLine($"y && DoStuff() = {y && DoStuff()}");
    }

    static bool DoStuff()
    {
        Console.WriteLine("I'm doing some stuff");
        return true;
    }
}
