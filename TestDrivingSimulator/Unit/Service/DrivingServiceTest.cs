using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary.Classes;
using ClassLibrary.Services;
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
            _drivingService = new DrivingService();
            _car = new Car();
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
        public void DriveForward_IncresesTidernessByTwo()
        {
            //Arrange
            var initialTiredness = _drivingService.GetTiredness();

            // Act
            _drivingService.DriveForward();

            //Assert
            Assert.AreEqual(initialTiredness + 2, _drivingService.GetTiredness());

        }


        [TestMethod]
        public void Refuel_SetsFuelTo100()
        {
            //Arrange
            var expectedFuel = 100;

            // Act
            _drivingService.Refuel();

            // Assert
            Assert.AreEqual(expectedFuel, _drivingService.GetFuel());
        }

        [TestMethod]
        public void Rest_SetsTirednessToZero()
        {
            //Arrange
            var expectedTiredness = 0;

            // Act
            _drivingService.Rest();

            // Assert
            Assert.AreEqual(expectedTiredness, _drivingService.GetTiredness());
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
            // Assuming that the Car starts with Fuel level of 100, we need to call DriveForward() 41 times to reach a Fuel level of 18
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
            // Assuming that the Car starts with Fuel level of 100, we need to call DriveForward() 39 times to reach a Fuel level of 22
            for (int i = 0; i < 39; i++)
            {
                _drivingService.DriveForward();
            }

            // Assert
            Assert.IsFalse(_drivingService.CheckIfFuelIsLow());
        }

    }

}
