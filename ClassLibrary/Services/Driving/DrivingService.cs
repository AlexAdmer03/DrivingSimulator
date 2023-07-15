using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary.Classes;
using System;
using System.Threading;

namespace ClassLibrary.Services.Driving
{


    public class DrivingService : IDrivingService
    {
        private Classes.Car _car = new Classes.Car();
        private Direction _direction = Direction.Norr;

        public DrivingService(Classes.Car car)
        {
            _car = car;
        }

        enum Direction { Norr, Syd, Öst, Väst }

        public void DriveForward()
        {
            _car.Fuel -= 2;
            _car.CarDriver.Tiredness += 2;
            Console.WriteLine("Du kör framåt.");
        }

        public void DriveBackward()
        {
            _car.Fuel -= 2;
            _car.CarDriver.Tiredness += 2;
            Console.WriteLine("Du kör bakåt.");
        }

        public void TurnLeft()
        {
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


        public bool CheckIfFuelIsLow()
        {
            if (_car.Fuel <= 20)
            {
                return true;
            }
            return false;
        }

        public string GetDirection()
        {
            return _direction.ToString();
        }

        public int GetFuel()
        {
            return _car.Fuel;
        }

        public int GetTiredness()
        {
            return _car.CarDriver.Tiredness;
        }

        private bool CheckIfDriverIsTired()
        {
            if (_car.CarDriver.Tiredness >= 80)
            {
                return true;
            }
            return false;
        }


    }
}
