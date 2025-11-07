using System;
using static System.Console;

class Program
{
    static void Main()
    {
        bool x = true;
        bool y = false;

        WriteLine($"AND | x    | y    ");
        WriteLine($"x   |{x & x,-5} |{x & y,-5}"); //x&x==-5, true
        WriteLine($"y   |{y & x,-5} |{y & y,-5}"); //y=false, all y=false
        WriteLine();

        WriteLine($"OR  | x    | y    ");
        WriteLine($"x   |{x | x,-5} |{x | y,-5}"); //
        WriteLine($"y   |{y | x,-5} |{y | y,-5}");
        WriteLine();

        WriteLine($"XOR | x    | y    ");
        WriteLine($"x   |{x ^ x,-5} |{x ^ y,-5}"); //or x, or y == -5
        WriteLine($"y   |{y ^ x,-5} |{y ^ y,-5}");
        WriteLine();

        WriteLine($"x & DoStuff() = {x & DoStuff()}");
        WriteLine();
        WriteLine($"y & DoStuff() = {y & DoStuff()}");
        WriteLine();
        WriteLine();
        WriteLine($"x && DoStuff() = {x && DoStuff()}");
        WriteLine();
        WriteLine($"y && DoStuff() = {y && DoStuff()}");
    }

    static bool DoStuff()
    {
        WriteLine("I'm doing some stuff");
        return true;
    }
}
