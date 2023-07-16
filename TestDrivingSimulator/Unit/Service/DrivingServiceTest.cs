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

        [TestMethod]
        public void TurnRight_ChangesDirectionCorrectly()
        {
            // Arrange
            var initialDirection = _drivingService.GetDirection();
            Assert.AreEqual("Norr", initialDirection);

            // Act
            _drivingService.TurnRight();

            // Assert
            var newDirection = _drivingService.GetDirection();
            Assert.AreEqual("Öst", newDirection);

            // Act
            _drivingService.TurnRight();

            // Assert
            newDirection = _drivingService.GetDirection();
            Assert.AreEqual("Syd", newDirection);
        }

        [TestMethod]
        public void TurnLeft_ChangesDirectionCorrectly()
        {
            // Arrange
            var initialDirection = _drivingService.GetDirection();
            Assert.AreEqual("Norr", initialDirection);

            // Act
            _drivingService.TurnLeft();

            // Assert
            var newDirection = _drivingService.GetDirection();
            Assert.AreEqual("Väst", newDirection);

            // Act
            _drivingService.TurnLeft();

            // Assert
            newDirection = _drivingService.GetDirection();
            Assert.AreEqual("Syd", newDirection);
        }

        //MENU TESTs



    }

}
