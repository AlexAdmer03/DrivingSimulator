using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary.Classes;
using System;
using System.Threading;

namespace ClassLibrary.Services
{


    public class DrivingService : IDrivingService
    {
        private Car _car = new Car();
        private Direction _direction = Direction.Norr;

        enum Direction { Norr, Syd, Öst, Väst }

        public void DriveForward()
        {
            if (_car.Fuel <= 0)
            {
                Console.WriteLine("Bensinen är slut, tanka bilen!");
                return;
            }

            _car.Fuel -= 2;
            _car.CarDriver.Tiredness += 2;
            Console.WriteLine("Du kör framåt.");
        }

        public void DriveBackward()
        {
            if (_car.Fuel <= 0)
            {
                Console.WriteLine("Bensinen är slut, tanka bilen!");
                return;
            }

            _car.Fuel -= 1;
            _car.CarDriver.Tiredness += 2;
            Console.WriteLine("Du kör bakåt.");
        }

        public void TurnLeft()
        {
            if (_car.Fuel <= 0)
            {
                Console.WriteLine("Bensinen är slut, tanka bilen!");
                return;
            }

            _car.Fuel -= 2;
            _car.CarDriver.Tiredness += 2;

            switch (_direction)
            {
                case Direction.Norr: _direction = Direction.Väst; break;
                case Direction.Väst: _direction = Direction.Syd; break;
                case Direction.Syd: _direction = Direction.Öst; break;
                case Direction.Öst: _direction = Direction.Norr; break;
            }

            Console.WriteLine("Du svänger till vänster.");
        }

        public void TurnRight()
        {
            if (_car.Fuel <= 0)
            {
                Console.WriteLine("Bensinen är slut, tanka bilen!");
                return;
            }

            _car.Fuel -= 2;
            _car.CarDriver.Tiredness += 2;

            switch (_direction)
            {
                case Direction.Norr: _direction = Direction.Öst; break;
                case Direction.Öst: _direction = Direction.Syd; break;
                case Direction.Syd: _direction = Direction.Väst; break;
                case Direction.Väst: _direction = Direction.Norr; break;
            }

            Console.WriteLine("Du svänger till höger.");
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

        public void Rest()
        {
            Console.WriteLine("Föraren Vilar...");
            Thread.Sleep(3000);
            _car.CarDriver.Tiredness = Math.Max(0, _car.CarDriver.Tiredness = 0);
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Du har vilat och minskat tröttheten.");
            Console.ResetColor();
        }

        public void DisplayCommands()
        {
            Console.WriteLine("=====================");
            Console.WriteLine("| Ange ett kommando:|");
            Console.WriteLine("| W = Kör framåt    |");
            Console.WriteLine("| S = Kör bakåt     |");
            Console.WriteLine("| A = Sväng vänster |");
            Console.WriteLine("| D = Sväng höger   |");
            Console.WriteLine("| R = Tanka bilen   |");
            Console.WriteLine("| F = Vila          |");
            Console.WriteLine("=====================");
        }

        public void DisplayStatus()
        {
            if (CheckIfFuelIsLow())
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Varning: Låg bensinnivå!");
                Console.ResetColor();
            }
            if (CheckIfDriverIsTired())
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Varning: Du är mycket trött!");
                Console.ResetColor();
            }
            Console.WriteLine($"Förarens trötthet: {_car.CarDriver.Tiredness}/100");
            Console.WriteLine($"Bilens bensin: {_car.Fuel}/100");
            Console.WriteLine($"Bilens riktning: {_direction}");
        }


        private bool CheckIfFuelIsLow()
        {
            if (_car.Fuel <= 20)
            {
                return true;
            }
            return false;
        }

        private bool CheckIfDriverIsTired()
        {
            if (_car.CarDriver.Tiredness >= 80)
            {
                return true;
            }
            return false;
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
