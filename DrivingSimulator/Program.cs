using ClassLibrary.Classes;
using ClassLibrary.Services;
using ClassLibrary.Services.Car;
using ClassLibrary.Services.Driver;
using ClassLibrary.Services.Driving;
using DrivingSimulator;

var car = new Car();
var driverService = new DriverService(car);
var carService = new CarService(car);
var drivingService = new DrivingService(car);
var randomUserService = new RandomUserService();
var app = new Application(drivingService, randomUserService, carService, driverService);
app.Run().GetAwaiter().GetResult();