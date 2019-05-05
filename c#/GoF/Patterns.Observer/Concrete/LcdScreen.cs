using Patterns.Observer.Abstraction;

namespace Patterns.Observer.Concrete
{
    public class LcdScreen : IObserver
    {
        private readonly ITemperatureSensor _sensor;

        public LcdScreen(ITemperatureSensor sensor)
        {
            _sensor = sensor;
        }

        public void Update()
        {
            var state = _sensor.GetTemperature();
            System.Console.WriteLine($"Observer {this.GetHashCode()} recive notification with state: {state}");
        }
    }
}
