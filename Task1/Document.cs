using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public abstract class Document
    {
        public abstract string DocumentName { get; protected set; }

        public abstract void Create(string path);
        public abstract void Open(string path);
        public abstract void Edit(string line);
    }
}
