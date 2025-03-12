using Lection9;

Console.WriteLine("mvc model");

Sensor model = new() { Temperature = 0, Humidity = 15 };
SensorView view = new();
SensorController controller = new(model, view);
controller.UpdateView();
controller.Temperature = 5;
controller.UpdateView();