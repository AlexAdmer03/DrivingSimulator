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
        private Direction _direction = Direction.North;

        enum Direction { North, South, East, West }

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
                case Direction.North: _direction = Direction.West; break;
                case Direction.West: _direction = Direction.South; break;
                case Direction.South: _direction = Direction.East; break;
                case Direction.East: _direction = Direction.North; break;
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
                case Direction.North: _direction = Direction.East; break;
                case Direction.East: _direction = Direction.South; break;
                case Direction.South: _direction = Direction.West; break;
                case Direction.West: _direction = Direction.North; break;
            }

            Console.WriteLine("Du svänger till höger.");
        }

        public void Refuel()
        {
            _car.Fuel = 100;
            Console.WriteLine("Du har tankat bilen.");
        }

        public void Rest()
        {
            Console.WriteLine("Vilar...");
            Thread.Sleep(5000);
            _car.CarDriver.Tiredness = Math.Max(0, _car.CarDriver.Tiredness - 10);
            Console.WriteLine("Du har vilat och minskat tröttheten.");
        }

        public void DisplayCommands()
        {
            Console.WriteLine("Ange ett kommando:");
            Console.WriteLine("W = Kör framåt");
            Console.WriteLine("S = Kör bakåt");
            Console.WriteLine("A = Sväng vänster");
            Console.WriteLine("D = Sväng höger");
            Console.WriteLine("R = Tanka bilen");
            Console.WriteLine("F = Vila");
        }

        public void DisplayStatus()
        {
            Console.WriteLine($"Förarens trötthet: {_car.CarDriver.Tiredness}/100");
            Console.WriteLine($"Bilens bensin: {_car.Fuel}/100");
            Console.WriteLine($"Bilens riktning: {_direction}");
        }

        public bool CheckIfDriverIsTooTired()
        {
            return _car.CarDriver.Tiredness >= 100;
        }
    }
}
