using ClassLibrary.Services;
using DrivingSimulator;

var drivingService = new DrivingService();
var randomUserService = new RandomUserService();
var app = new Application(drivingService, randomUserService);
app.Run().GetAwaiter().GetResult();