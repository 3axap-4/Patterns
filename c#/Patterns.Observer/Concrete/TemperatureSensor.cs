using Patterns.Observer.Abstraction;
using System;
using System.Collections.Generic;
using System.Timers;

namespace Patterns.Observer.Concrete
{
    public class TemperatureSensor : ITemperatureSensor, IObservervable
    {
        private ICollection<IObserver> _observers;
        private Random _random;
        //private Timer _measurementTimer;

        public TemperatureSensor()
        {
            _observers = new List<IObserver>();

            _random = new Random(10000);

            // can be used for simulate work
            //_measurementTimer = new Timer(TimeSpan.FromSeconds(5).TotalMilliseconds);
            //_measurementTimer.Elapsed += CheckTemperature;
            //_measurementTimer.Start();
        }

        private void CheckTemperature(object sender, ElapsedEventArgs e)
        {
            Notify();
        }

        public void Add(IObserver observer)
        {
            _observers.Add(observer);
        }

        public double GetTemperature()
        {
            // usеd for generate random data
            return _random.Next(-10, 20);
        }

        public void Notify()
        {
            foreach (var o in _observers)
                o.Update();
        }

        public void Remove(IObserver observer)
        {
            _observers.Remove(observer);
        }
    }
}