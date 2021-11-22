using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Console.OutputEncoding = System.Text.Encoding.Unicode;

            var items = ScanMedia("Media");

            Console.WriteLine("Знайдені файли медіа:");

            foreach (var item in items)
                item.Print();

            Console.WriteLine();

            Console.ReadLine();
        }

        static List<PlayerItem> ScanMedia(string folderPath)
        {
            var result = new List<PlayerItem>();
            var files = Directory.EnumerateFiles(folderPath);

            foreach (var file in files)
            {
                string extension = Path.GetExtension(file);

                if (extension == ".mkv") { result.Add(new PlayerItem(new Mkv(file))); }
                if (extension == ".mp3") { result.Add(new PlayerItem(new Mp3(file))); }
                if (extension == ".wav") { result.Add(new PlayerItem(new Wav(file))); }
            }

            return result;
        }
    }
}
