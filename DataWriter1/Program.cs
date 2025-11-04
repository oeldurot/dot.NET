using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Runtime;

namespace DataWriter1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write your email...");
            var email = Console.ReadLine();
            Console.WriteLine("Write your password...");
            var password = Console.ReadLine();
            Console.WriteLine("Write your path...");
            var path = Console.ReadLine();

            var email1 = new string(email);
            var password1 = new string(password);
            var path1 = new string(path);


            Program Program1 = new ();
            //Console.WriteLine($"{email1},{password1},{path1}");
        }

        public class Program1
        { 
            public static void Create(string path1, System.Collections.Generic.IEnumerable<string> contents, UTF32Encoding encoding)
            {
                using (FileStream fs = File.Create(path1));
            }
        }    

    }
}