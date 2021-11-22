using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Console.OutputEncoding = System.Text.Encoding.Unicode;

            Console.WriteLine("Ця програма допоможе вирішити що вам потрібно: принтер, сканер, копіювальний пристрій чи БФП.");
            Console.WriteLine();
            Console.WriteLine("Для цього вам треба відповісти на декілька простих запитань:");
            Console.WriteLine();
            Console.WriteLine("1. Чи потрібен вам друк з ПК/смартфону/флешки і т. ін.?");
            Console.WriteLine(" 1) Так");
            Console.WriteLine(" 2) Ні");
            Console.WriteLine();
            Console.Write("Ваша відповідь: ");
            int answ1, answ2;
            answ1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            if (answ1 == 1)
            {
                Console.WriteLine("2. Чи потрібне вам копіювання документів?");
                Console.WriteLine(" 1) Так");
                Console.WriteLine(" 2) Ні");
                Console.WriteLine();
                Console.Write("Ваша відповідь: ");
                answ2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                if (answ2 == 1)
                {
                    Console.WriteLine("Вам підходить БФП.");
                    Console.WriteLine();
                    MFD mfd = new MFD();

                    mfd.PrintFunctions();
                    mfd.Noise();
                }
                if (answ2 == 2)
                {
                    Console.WriteLine("Вам підходить принтер.");
                    Console.WriteLine();
                    Printer printer = new Printer();

                    printer.PrintFunctions();
                    printer.Noise();
                }
            }

            if (answ1 == 2)
            {
                Console.WriteLine("2. Чи потрібне вам копіювання документів?");
                Console.WriteLine(" 1) Так");
                Console.WriteLine(" 2) Ні");
                Console.WriteLine();
                Console.Write("Ваша відповідь: ");
                answ2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                if (answ2 == 1)
                {
                    Console.WriteLine("Вам підходить копіювальний апарат.");
                    Console.WriteLine();
                    Copier copier = new Copier();

                    copier.PrintFunctions();
                    copier.Noise();
                }
                
                if (answ2 == 2)
                {
                    Console.WriteLine("Вам підходить сканер.");
                    Console.WriteLine();
                    Scanner scanner = new Scanner();

                    scanner.PrintFunctions();
                    scanner.Noise();
                }
            }

            Console.ReadKey();
        }
    }
}
