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
            int userInputA = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Indsæt heltal (B)");
            int userInputB = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Addition = {Addition(userInputA, userInputB)}");
            Console.WriteLine($"Division = {Division(userInputA, userInputB)}");
            Console.WriteLine($"Modulus = {Modulus(userInputA, userInputB)}");
            Console.WriteLine($"Potency = {Potency(userInputA, userInputB)}");

            Console.ReadKey();
        }

        static int Addition(int userInputA, int userInputB)
        {
            return userInputA + userInputA;
        }
        static int Division(int userInputA, int userInputB)
        {
            return userInputA / userInputA;
        }
        static int Modulus(int userInputA, int userInputB)
        {
            return userInputA % userInputA;
        }
        static double Potency(int userInputA, int userInputB)
        {
            //Can't Convert 2^3!
            return (int)Math.Pow(userInputB, userInputB);
        }
    }
}
