using System;
using System.IO;

namespace IterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            string? password;
            int count = 0;

            for (int y = 1; y <= 10; y++)
            {
                Console.WriteLine(y);
            }

            while (x<=10)
            {
                Console.WriteLine(x);
                x++;
            }

            do
            {
                Console.Write("Enter your password: ");
                password = Console.ReadLine();
                count++;
                if (count == 10)
                {
                    Console.WriteLine("Вы использовали все попытки ввода пароля!");
                    break;
                }
            }
            while (password != "248609");

        }
    }
}
