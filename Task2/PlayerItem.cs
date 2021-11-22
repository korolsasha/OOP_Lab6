using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class PlayerItem
    {
        public IMedia File { get; }

        public PlayerItem(IMedia file) { File = file; }

        public void Print()
        {
            Console.Write($"Файл \"{File.FileName}\": ");

            if (File is IPlayable) { Console.Write("Play, "); }

            if (File is IRecordable) { Console.Write("Record, "); }

            Console.WriteLine("Pause, Stop;");
        }
    }
}
