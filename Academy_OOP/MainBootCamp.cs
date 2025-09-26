using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy_OOP
{
    internal class MainBootCamp
    {
        public List<BootCamp> BootCamps { get; private set; }
        public int Type { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public MainBootCamp(int type, string name, string description)
        {
            BootCamps = new List<BootCamp>();
            this.Type = type;
            this.Name = name;
            this.Description = description;
        }
    }
}
