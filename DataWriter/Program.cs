using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace DataWriter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write your email...");
            string email = Console.ReadLine();
            Console.WriteLine("Write your password...");
            string password = Console.ReadLine();
            Console.WriteLine("Write your path...");
            string path = Console.ReadLine();

            string email1 = new string(email);
            string password1 = new string(password);
            string path1 = new string(path);

            Console.WriteLine($"{email1},{password1},{path1}");

        }

        extern AppendAllLines(string email1, IEnumerable<string> email1, UTF7Encoding email1);
    }

}
