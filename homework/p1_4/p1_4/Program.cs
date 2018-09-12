using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p1_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string n = "";
            int a = 0;
            int b = 0;
            int sum = 0;
            Console.Write("Enter num1:");
            n = Console.ReadLine();
            a = Int32.Parse(n);
            Console.Write("Enter num2:");
            n = Console.ReadLine();
            b = Int32.Parse(n);
            sum = a * b;
            Console.Write(sum);
        }
    }
}
