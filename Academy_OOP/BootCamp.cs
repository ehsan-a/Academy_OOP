using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy_OOP
{

    internal class BootCamp
    {
        public List<Student> Students { get; private set; }
        public Employee Employee { get; set; }
        public Room Room { get; set; }
        public int Type { get; set; }
        public DateTime StartDate { get; set; }
        public BootCamp(int Type, DateTime StartDate)
        {
            Students = new List<Student>();
            this.Type = Type;
            this.StartDate = StartDate;
        }
    }
}
