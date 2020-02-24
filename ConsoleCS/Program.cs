using System;

namespace ConsoleCS
{
    public class Program
    {
        static public int fv(int a, int b, int c)
        {
            return (a * b * c);
        }
        static public int fs(int a, int b, int c)
        {
            return (2 * a * b + 2 * a * c + 2 * b * c);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введiть перший вимiр");
            string S = Console.ReadLine();
            int a = int.Parse(S);
            Console.WriteLine("Введiть другий вимiр");
            S = Console.ReadLine();
            int b = int.Parse(S);
            Console.WriteLine("Введiть третiй вимiр");
            S = Console.ReadLine();
            int c = int.Parse(S);
            Console.Write("v = ");
            Console.WriteLine(fv(a, b, c));
            Console.Write("s = ");
            Console.WriteLine(fs(a, b, c));
            Console.ReadKey();
        }
    }
}
