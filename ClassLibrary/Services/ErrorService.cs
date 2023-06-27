using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Services
{
    public class ErrorService
    {
        public void ShowInvalidCommandError()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Ogiltigt kommando. Vänligen ange ett giltigt kommando");
            Console.ResetColor();
        }
    }
}
