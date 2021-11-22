using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class Printer : NoiseLevel, Print
    {
        public void Print() { }

        public void PrintFunctions()
        {
            Console.WriteLine("До його функцій входить:");
            Console.WriteLine(" - друк.");
            Console.WriteLine();
        }

        public override void Noise()
        {
            Console.WriteLine("Рівень шуму: середній.");
        }
    }
}
