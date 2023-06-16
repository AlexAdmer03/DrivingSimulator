using ClassLibrary.Services;
using DrivingSimulator;

var drivingService = new DrivingService();
var app = new Application(drivingService);
app.Run();
