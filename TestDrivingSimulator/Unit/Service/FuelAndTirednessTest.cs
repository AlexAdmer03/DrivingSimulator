using ClassLibrary.Classes;
using ClassLibrary.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDrivingSimulator.Unit.Service
{
    public class FuelAndTirednessTest
    {
        [TestClass]
        public class UnitTest1
        {
            [TestClass]
            public class DrivingServiceTests
            {
                private DrivingService _sut;
                private Car _car;

                [TestInitialize]
                public void TestInitialize()
                {
                    _sut = new DrivingService();
                    _car = new Car();
                }

                [TestMethod]
                public void DriveForward_Should_Increase_Tiredness()
                {
                    // Arrange
                    var initialTiredness = _car.CarDriver.Tiredness;

                    // Act
                    _sut.DriveForward();

                    // Assert
                    Assert.IsTrue(_car.CarDriver.Tiredness > initialTiredness);
                }

                [TestMethod]
                public void Refuel_Should_Fill_Up_Fuel()
                {
                    // Arrange
                    _car.Fuel = 0;

                    // Act
                    _sut.Refuel();

                    // Assert
                    Assert.IsTrue(_car.Fuel == 100);
                }

                [TestMethod]
                public void TurnRight_Should_Change_Direction()
                {
                    // Arrange
                    var initialDirection = "Norr";

                    // Act
                    _sut.TurnRight();

                    // Assert
                    Assert.AreNotEqual(initialDirection, _sut.GetDirection());
                }

                [TestMethod]
                public void TurnRight_Should_Consume_Fuel()
                {
                    // Arrange
                    var initialFuel = _car.Fuel;

                    // Act
                    _sut.TurnRight();

                    // Assert
                    Assert.IsTrue(_car.Fuel < initialFuel);
                }

                [TestMethod]
                public void CheckIfDriverIsTooTired_Should_Return_True_If_Tiredness_Is_Max()
                {
                    // Arrange
                    _car.CarDriver.Tiredness = 100;

                    // Act
                    var result = _sut.CheckIfDriverIsTooTired();

                    // Assert
                    Assert.IsTrue(result);
                }
            }
        }
    }
}
