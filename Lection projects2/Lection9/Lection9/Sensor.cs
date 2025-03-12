namespace Lection9
{
    public class Sensor
    {
        public int Temperature { get; set; }
        public int Humidity { get; set; }
    }

    public class SensorView
    {
        public void PrintInfo(int temperature, int humidity)
            => Console.WriteLine($"t={temperature} h={humidity}");
    }

    public class SensorController
    {
        private Sensor model;
        private SensorView view;

        public SensorController(Sensor sensor, SensorView sensorView)
        {
            this.model = sensor;
            this.view = sensorView;
        }

        public int Temperature
        {
            get => model.Temperature;
            set => model.Temperature = value;
        }

        public int Humidity
        {
            get => model.Humidity;
            set => model.Humidity = value;
        }

        public void UpdateView() 
            => view.PrintInfo(Temperature, Humidity);
    }
}
