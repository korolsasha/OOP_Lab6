using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class Copier : NoiseLevel, Copy
    {
        public void Copy() { }

        public void PrintFunctions()
        {
            Console.WriteLine("До його функцій входить:");
            Console.WriteLine(" - копіювання.");
            Console.WriteLine();
        }

        public override void Noise()
        {
            Console.WriteLine("Рівень шуму: середній.");
        }
    }
}
