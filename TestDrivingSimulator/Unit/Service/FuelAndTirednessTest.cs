using ClassLibrary.Classes;
using ClassLibrary.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDrivingSimulator.Unit.Service
{
    [TestClass]
    public class FuelAndTirednessTest
    {
        private DrivingService _drivingService;

        [TestInitialize]
        public void Setup()
        {
            _drivingService = new DrivingService();
        }

        [TestMethod]
        public void DriveForward_DecreasesFuelByTwoAndIncreasesTirednessByTwo()
        {
            // Arrange
            var initialFuel = _drivingService.GetFuel();
            var initialTiredness = _drivingService.GetTiredness();

            // Act
            _drivingService.DriveForward();

            // Assert
            Assert.AreEqual(initialFuel - 2, _drivingService.GetFuel());
            Assert.AreEqual(initialTiredness + 2, _drivingService.GetTiredness());
        }

        // Similarly for DriveBackward, TurnLeft, TurnRight

        [TestMethod]
        public void Refuel_SetsFuelTo100()
        {
            // Act
            _drivingService.Refuel();

            // Assert
            Assert.AreEqual(100, _drivingService.GetFuel());
        }

        [TestMethod]
        public void Rest_SetsTirednessToZero()
        {
            // Act
            _drivingService.Rest();

            // Assert
            Assert.AreEqual(0, _drivingService.GetTiredness());
        }
    }
}
