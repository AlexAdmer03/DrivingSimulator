using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace DrivingSimulator
{
    public class Application
    {
        public void Run()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Welcome to the Driving Simulation!");
            Console.ResetColor();
           
            
            bool continueProgram = true;
            while (continueProgram)
            {
                Console.WriteLine("Please enter a command: \n1: Start Driving\n0: Exit");
                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        Console.WriteLine("Start Driving");
                        // Include the logic for 'Start Driving' here
                        break;
                    case "0":
                        Console.WriteLine("Exiting...");
                        continueProgram = false;
                        break;
                    default:
                        Console.WriteLine("Invalid input. Please enter 1 to start driving or 0 to exit.");
                        break;
                }
            }

           
        }
    }
}
