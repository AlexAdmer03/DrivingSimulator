using ClassLibrary.Classes;
using ClassLibrary.Services.Car;
using ClassLibrary.Services.Driving;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDrivingSimulator.Unit.Service
{
    [TestClass]
    public class CarServiceTest
    {
        private ICarService _carService;
        private DrivingService _drivingService;
        private Car _car;

        [TestInitialize]
        public void Setup()
        {
            _car = new Car();
            _drivingService = new DrivingService(_car);
            _carService = new CarService(_car);
        }

        [TestMethod]
        public void DriveForward_DecreasesFuelByTwo()
        {
            // Arrange
            var initialFuel = _drivingService.GetFuel();

            // Act
            _drivingService.DriveForward();

            // Assert
            Assert.AreEqual(initialFuel - 2, _drivingService.GetFuel());
        }

        [TestMethod]
        public void Refuel_SetsFuelTo100()
        {
            //Arrange
            var expectedFuel = 100;

            // Act
            _carService.Refuel();

            // Assert
            Assert.AreEqual(expectedFuel, _drivingService.GetFuel());
        }

        [TestMethod]
        public void Turnleft_DecreasesFuelByTwo()
        {
            // Arrange
            var initialFuel = _drivingService.GetFuel();

            // Act
            _drivingService.TurnLeft();

            // Assert
            Assert.AreEqual(initialFuel - 2, _drivingService.GetFuel());
        }

        [TestMethod]
        public void DriveBackward_DecreasesFuelByTwo()
        {
            // Arrange
            var initialFuel = _drivingService.GetFuel();

            // Act
            _drivingService.DriveBackward();

            // Assert
            Assert.AreEqual(initialFuel - 2, _drivingService.GetFuel());
        }

        [TestMethod]
        public void CheckIfFuelIsLow_WhenFuelIsLessThan20_ShouldReturnTrue()
        {
            // Act
            for (int i = 0; i < 41; i++)
            {
                _drivingService.DriveForward();
            }

            // Assert
            Assert.IsTrue(_drivingService.CheckIfFuelIsLow());
        }

        [TestMethod]
        public void CheckIfFuelIsLow_WhenFuelIsMoreThan20_ShouldReturnFalse()
        {
            // Act
            for (int i = 0; i < 39; i++)
            {
                _drivingService.DriveForward();
            }

            // Assert
            Assert.IsFalse(_drivingService.CheckIfFuelIsLow());
        }
    }
}
