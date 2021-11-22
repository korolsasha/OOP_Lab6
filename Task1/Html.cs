using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Html : Document
    {
        public override string DocumentName {get; protected set; }
        public override void Create(string path) { }
        public override void Open(string path) { }
        public override void Edit(string line) { }
    }
}
