using System;
using System.IO;

namespace SelectionStatements
{
    class Programm
    {
        static void Main(string[] args)
        {
            string path = @"D:\Games";

            Console.WriteLine("Press R for read-only or W for writeable: "); //выбор read-only or writeable
            ConsoleKeyInfo key = Console.ReadKey();
            Console.WriteLine();

            Stream? s;

            if (key.Key == ConsoleKey.R) //если введенная с клавиатуры клавиша равняется клавише R or W
            {
                s = File.Open(Path.Combine(path, "file.txt"), FileMode.Open, FileAccess.Read);
            }   //комбинируется путь и имя конечного файла, создается или открывается файл с заданным именем и типом доступа к файлу
            else
            {
                s = File.Open(Path.Combine(path, "file.txt"), FileMode.OpenOrCreate, FileAccess.Write);
            }   //комбинируется путь и имя конечного файла, создается или открывается файл с заданным именем и типом доступа к файлу

            string message;

            switch (s)
            {
                case FileStream writeableFile when s.CanWrite:
                    message = "The stream is a file that I can write to.";
                    break;

                case FileStream readOnlyFile when s.CanRead:
                    message = "The stream is a read-only file.";
                    break;
                case MemoryStream ms:
                    message = "The stream is a memory address";
                    break;

                default:
                    message = "The stream is some other type";
                    break;

                case null:
                    message = "The stream is null";
                    break;
            }
            Console.WriteLine(message);

        }
    }
}
