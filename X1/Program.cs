using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace X1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("We want to get the delta");
            Console.Write("Enter b: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Enter a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter c: ");
            int c = int.Parse(Console.ReadLine());
            double x1 = (-(b) + Math.Sqrt(b * b) - 4 * a * c) / 2 * a;
            Console.WriteLine("Delta is : " + x1);
            Console.ReadKey();
        }
    }
}
