﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task2
{
    class Wav : IPlayable, IRecordable
    {
        public string FilePath => filePath;
        private string filePath;

        public string FileName => fileName;
        private string fileName;

        public Wav(string path)
        {
            filePath = path;
            fileName = Path.GetFileName(path);
        }

        public void Play() { }
        public void Pause() { }
        public void Stop() { }
        public void Record() { }
    }
}
