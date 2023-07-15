using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary.Classes;
using ClassLibrary.Services.Car;
using ClassLibrary.Services.Driving;
using Range = System.Range;

namespace TestDrivingSimulator.Unit.Service
{
    [TestClass]
    public class DrivingServiceTest
    {
        private DrivingService _drivingService;
        private Car _car;

        [TestInitialize]
        public void Setup()
        {
            _car = new Car();
            _drivingService = new DrivingService(_car);
        }

        


    }

}
