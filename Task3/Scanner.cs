using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class Scanner : NoiseLevel, Scan
    {
        public void Scan() { }

        public void PrintFunctions()
        {
            Console.WriteLine("До його функцій входить:");
            Console.WriteLine(" - сканування.");
            Console.WriteLine();
        }

        public override void Noise()
        {
            Console.WriteLine("Рівень шуму: низький.");
        }
    }
}
