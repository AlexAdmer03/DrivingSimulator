using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace DrivingSimulator
{
    using ClassLibrary.Services;
    using System;

    public class Application
    {
        private readonly IDrivingService _drivingService;

        public Application(IDrivingService drivingService)
        {
            _drivingService = drivingService;
        }

        public void Run()
        {
            Console.WriteLine("Välkommen till bilkörningssimuleringen!");

            while (true)
            {
                Console.WriteLine("1. Starta körning\n0. Avsluta simulatorn");
                var input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        StartDriving();
                        break;
                    case "0":
                        Console.WriteLine("Exiting Simulation");
                        return;
                    default:
                        Console.WriteLine("Ogiltigt val, försök igen.");
                        break;
                }
            }
        }

        private void StartDriving()
        {
            _drivingService.DisplayCommands();

            while (true)
            {
                var input = Console.ReadLine().ToUpper();

                if (_drivingService.CheckIfDriverIsTooTired())
                {
                    Console.WriteLine("Föraren är för trött och kan inte köra längre.");
                    break;
                }

                switch (input)
                {
                    case "W":
                        _drivingService.DriveForward();
                        break;
                    case "S":
                        _drivingService.DriveBackward();
                        break;
                    case "A":
                        _drivingService.TurnLeft();
                        break;
                    case "D":
                        _drivingService.TurnRight();
                        break;
                    case "R":
                        _drivingService.Refuel();
                        break;
                    case "F":
                        _drivingService.Rest();
                        break;
                    default:
                        Console.WriteLine("Ogiltigt kommando.");
                        break;
                }

                _drivingService.DisplayStatus();
                _drivingService.DisplayCommands();
            }
        }
    }
}