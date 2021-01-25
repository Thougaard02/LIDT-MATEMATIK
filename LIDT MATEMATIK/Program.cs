using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIDT_MATEMATIK
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Indsæt heltal (A)");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Indsæt heltal (B)");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Addition = {a + b}");
            Console.WriteLine($"Division = {a / b}");
            Console.WriteLine($"Potency {Math.Pow(a, b)}");
            Console.ReadKey();
        }
    }
}
