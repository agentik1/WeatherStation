using System;
using System.Collections.Generic;
using System.Text;

namespace obs3rv3r
{
    class WeatherData : Subject
    {
        private List<Observer> observers;
        private float temp;
        private float humidity;
        private float pressure;

        public void measurementsChanged()
        {
            notifyObservers();
        }

        public void setMeasurements(float temp, float humidity, float pressure)
        {
            this.temp = temp;
            this.humidity = humidity;
            this.pressure = pressure;

            measurementsChanged();
        }

        public WeatherData()
        {
            observers = new List<Observer>();
        }

        public void notifyObservers()
        {
            foreach (var observer in observers)
            {
                observer.update(temp, humidity, pressure);
            }
        }
        public void registerObserver(Observer o)
        {
            observers.Add(o);
        }
        public void removeObserver(Observer o)
        {
            observers.Remove(o);
        }
    }
}
