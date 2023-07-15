using ClassLibrary.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Services.Driver
{
    public class DriverService : IDriverService
    {
        private Classes.Car _car = new Classes.Car();

        public DriverService(Classes.Car car)
        {
            _car = car;
        }

        public void Rest()
        {
            Console.WriteLine("Föraren Vilar...");
            Thread.Sleep(3000);
            _car.CarDriver.Tiredness = Math.Max(0, _car.CarDriver.Tiredness = 0);
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Du har vilat och minskat tröttheten.");
            Console.ResetColor();
        }

        public bool CheckIfDriverIsTooTired()

        {
            if (_car.CarDriver.Tiredness >= 100)
            {
                Console.Clear();
                Console.WriteLine("Du är för trött och kan inte köra längre. Du blev bärgad till ett hotell för att vila.");
                Rest();
                return true;
            }
            return false;
        }
    }
}
