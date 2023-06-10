using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Classes
{
    public class Car
    {
        public int Fuel { get; set; }
        public string Direction { get; set; }
        public string AbleToDrive { get; set; }

        public Driver CarDriver { get; set; } = new Driver();
    }
}
