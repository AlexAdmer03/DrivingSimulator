using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Services.Driving
{
    public interface IDrivingService
    {
        void DriveForward();
        void DriveBackward();
        void TurnLeft();
        void TurnRight();
        void DisplayCommands();
        void DisplayStatus();
    }
}
