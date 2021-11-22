using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task2
{
    public class Mp3 : IRecordable
    {
        public string FilePath => filePath;
        private string filePath;

        public string FileName => fileName;
        private string fileName;

        public Mp3(string path)
        {
            filePath = path;
            fileName = Path.GetFileName(path);
        }

        public void Record() { }
        public void Pause() { }
        public void Stop() { }
    }
}
