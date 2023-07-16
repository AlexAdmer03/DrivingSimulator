using ClassLibrary.Classes;
using ClassLibrary.Services.Car;
using ClassLibrary.Services.Driving;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary.Services.Driver;

namespace TestDrivingSimulator.Unit.Service
{
    [TestClass]
    public class DriverServiceTest
    {
        private ICarService _carService;
        private DrivingService _drivingService;
        private IDriverService _driverService;
        private Car _car;

        [TestInitialize]
        public void Setup()
        {
            _car = new Car();
            _drivingService = new DrivingService(_car);
            _driverService = new DriverService(_car);
        }

        [TestMethod]
        public void Rest_SetsTirednessToZero()
        {
            // Arrange
            var expectedTiredness = 0;
            _car.CarDriver.Tiredness = 50; 

            // Act
            _driverService.Rest();

            // Assert
            Assert.AreEqual(expectedTiredness, _car.CarDriver.Tiredness);
        }


        [TestMethod]
        public void TurnRight_IncresesTidernessByTwo()
        {
            //Arrange
            var initialTiredness = _drivingService.GetTiredness();

            // Act
            _drivingService.TurnRight();

            //Assert
            Assert.AreEqual(initialTiredness + 2, _drivingService.GetTiredness());

        }

        [TestMethod]
        public void DriveBackward_IncresesTidernessByTwo()
        {
            //Arrange
            var initialTiredness = _drivingService.GetTiredness();

            // Act
            _drivingService.DriveBackward();

            //Assert
            Assert.AreEqual(initialTiredness + 2, _drivingService.GetTiredness());

        }

        [TestMethod]
        public void DriveForward_IncresesTidernessByTwo()
        {
            //Arrange
            var initialTiredness = _drivingService.GetTiredness();

            // Act
            _drivingService.DriveForward();

            //Assert
            Assert.AreEqual(initialTiredness + 2, _drivingService.GetTiredness());

        }
    }
}
