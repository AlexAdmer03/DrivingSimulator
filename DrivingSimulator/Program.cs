
using ClassLibrary.Services;
using DrivingSimulator;

var app = new Application();
app.Run();

    static void Main(string[] args)
    {
        IDrivingService carService = new DrivingService();
        carService.DriveCar();
    }

