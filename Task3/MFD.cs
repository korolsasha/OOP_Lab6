using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class MFD : NoiseLevel, Print, Scan, Copy
    {
        public void Print() { }
        public void Scan() { }
        public void Copy() { }

        public void PrintFunctions()
        {
            Console.WriteLine("До його функцій входить:");
            Console.WriteLine(" - друк;");
            Console.WriteLine(" - сканування;");
            Console.WriteLine(" - копіювання.");
            Console.WriteLine();
        }

        public override void Noise()
        {
            Console.WriteLine("Рівень шуму: середній під час друку/копіювання; низький під час сканування.");
        }

    }
}
