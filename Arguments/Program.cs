using static System.Console;

namespace Arguments
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteLine($"There are {args.Length} arguments");

            foreach (string arg in args)
            {
                Console.WriteLine(arg);
            }

        }
    }
}
