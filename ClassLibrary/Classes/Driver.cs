using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Classes
{
    public class Driver
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Tiredness { get; set; }
        public int Hunger { get; set; }

        public Driver()
        {
            Tiredness = 0;
            Hunger = 0;
        }

    }
}
