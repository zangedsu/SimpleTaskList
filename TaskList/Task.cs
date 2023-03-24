using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskList
{
    internal class Task
    {
        public string Name { get; private set; }
        public string DateFrom { get; private set; }
        public string DateTo { get; private set; }
        public string About { get; private set; }
        public string InProcess { get; private set; }

        public Task(string name, string datefrom, string dateto, string about, string inprocess)
        {
            Name = name;
            DateFrom = datefrom;
            DateTo = dateto;
            InProcess = inprocess;
            About = about;
        }

        public override string ToString()
        {
            // +"|" + InProcess + "|"
            return Name;
        }
    }
}
