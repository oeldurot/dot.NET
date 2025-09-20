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


            if (args.Length < 3)
            {
                WriteLine("Ты должен выбрать два цвета и размер курсора");
                WriteLine("dotnet run red yellow 50");
                return;
            }

            ForegroundColor = (ConsoleColor)Enum.Parse(enumType: typeof(ConsoleColor), value: args[0], ignoreCase: true);

            BackgroundColor = (ConsoleColor)Enum.Parse(enumType: typeof(ConsoleColor), value: args[1], ignoreCase: true);

            CursorSize = int.Parse(args[2]);

        }
    }
}
