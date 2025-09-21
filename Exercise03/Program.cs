using static System.Console;
using static System.Math;


namespace Exercise03
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //type
            //bytes of memory
            //min value
            //max value
            for (int i = 0; i < 95; i++)
            {
                Write($"_");
            }
            WriteLine("");
            WriteLine("");
            WriteLine($"Type {"Byte(s) of memory",23} {"Min",28} {"Max",37}");

            for (int i = 0; i < 95; i++)
            {
                Write($"_");
            }

            WriteLine("");
            WriteLine($"sbyte {sizeof(sbyte),6} {sbyte.MinValue,44} {sbyte.MaxValue,37}");
            WriteLine($"byte  {sizeof(byte),6} {byte.MinValue,44} {byte.MaxValue,37}");
            WriteLine($"short {sizeof(short),6} {short.MinValue,44} {short.MaxValue,37}");
            WriteLine($"ushort {sizeof(ushort),5} {ushort.MinValue,44} {ushort.MaxValue,37}");
            WriteLine($"int {sizeof(int),8} {int.MinValue,44} {int.MaxValue,37}");
            WriteLine($"uint {sizeof(uint),7} {uint.MinValue,44} {uint.MaxValue,37}");
            WriteLine($"long {sizeof(long),7} {long.MinValue,44} {long.MaxValue,37}");
            WriteLine($"ulong {sizeof(ulong),6} {ulong.MinValue,44} {ulong.MaxValue,37}");
            WriteLine($"float {sizeof(float),6} {float.MinValue,44} {float.MaxValue,37}");
            WriteLine($"double {sizeof(double),5} {double.MinValue,44} {double.MaxValue,37}");
            WriteLine($"decimal {sizeof(decimal),5} {decimal.MinValue,43} {decimal.MaxValue,37}");

            for (int i = 0; i < 95; i++)
            {
                Write($"_");
            }
        }
    }
}
