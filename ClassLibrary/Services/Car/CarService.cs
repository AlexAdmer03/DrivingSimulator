using ClassLibrary.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Services.Car
{
    public class CarService : ICarService
    {
        private Classes.Car _car = new Classes.Car();

        public CarService(Classes.Car car)
        {
            _car = car;
        }

        public void Refuel()
        {
            Console.WriteLine("Tankar Bilen...");
            Thread.Sleep(3000);
            _car.Fuel = 100;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Du har tankat bilen.");
            Console.ResetColor();
        }
        public bool CheckIfFuelIsEmpty()
        {
            if (_car.Fuel <= 0)
            {
                Console.Clear();
                Console.WriteLine("Bensinen är slut, du kan inte köra längre. Du blev bärgad till närmaste bensinmack.");
                Refuel();
                return true;
            }
            return false;
        }
        
    }
}
