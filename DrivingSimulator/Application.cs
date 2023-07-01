using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using ClassLibrary.Services;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace DrivingSimulator
{
    using ClassLibrary.Services;
    using System;
    using System.Xml.Linq;

    public class Application
    {
        private readonly IDrivingService _drivingService;
        private readonly ErrorService _errorService;
        private readonly RandomUserService _randomUserService;
        public Application(IDrivingService drivingService, RandomUserService randomUserService)
        {
            _drivingService = drivingService;
            _errorService = new ErrorService();
            _randomUserService = randomUserService;
        }


        public async Task Run()
        {
            string userName = await _randomUserService.GetRandomUserAsync();
            
            while (true)
            {
                Console.WriteLine("===========================================");
                Console.WriteLine("| Välkommen till bilkörningssimuleringen! |");
                Console.WriteLine($"    Din förare idag är {userName}");
                Console.WriteLine("|                                         |");
                Console.WriteLine("|         1. Starta körning               |\n|         0. Avsluta simulatorn           |");
                Console.WriteLine("===========================================");
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
                        _errorService.ShowInvalidCommandError();
                        break;
                }

                
            }
        }

        private void StartDriving()
        {
            Console.Clear();
            _drivingService.DisplayCommands();

            while (true)
            {
                var input = Console.ReadLine().ToUpper();

                if (_drivingService.CheckIfDriverIsTooTired() || _drivingService.CheckIfFuelIsEmpty())
                {
                    Console.WriteLine("1. Fortsätt köra\n0. Avsluta simulator");
                    input = Console.ReadLine();

                    switch (input)
                    {
                        case "1":
                            break;
                        case "0":
                            Console.WriteLine("Avslutar Simulation");
                            return;
                        default:
                            Console.WriteLine("Ogiltigt val, försök igen.");
                            continue;
                    }
                }

                switch (input)
                {
                    case "W":
                        Console.Clear();
                        _drivingService.DriveForward();
                        break;
                    case "S":
                        Console.Clear();
                        _drivingService.DriveBackward();
                        break;
                    case "A":
                        Console.Clear();
                        _drivingService.TurnLeft();
                        break;
                    case "D":
                        Console.Clear();
                        _drivingService.TurnRight();
                        break;
                    case "R":
                        Console.Clear();
                        _drivingService.Refuel();
                        break;
                    case "F":
                        Console.Clear();
                        _drivingService.Rest();
                        break;
                    default:
                        _errorService.ShowInvalidCommandError();
                        break;
                }

                
                _drivingService.DisplayStatus();
                _drivingService.DisplayCommands();
            }
        }
    }
}
