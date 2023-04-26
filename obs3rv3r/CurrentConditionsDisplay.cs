using System;
using System.Collections.Generic;
using System.Text;

namespace obs3rv3r
{
    public class CurrentConditionsDisplay : Observer, DisplayElement
    {
        private float temp;
        private float humidity;
        private float pressure;
        private Subject weatherData;

        public CurrentConditionsDisplay(Subject weatherData)
        {
            this.weatherData = weatherData;
            weatherData.registerObserver(this);
        }
        public void display()
        {
            Console.WriteLine("Current conditions: " + temp + "C degrees and " + humidity + "% humidity" +
                pressure + " pressure");
        }

        public void update(float temp, float humidity, float pressure)
        {
            throw new NotImplementedException();
        }
    }
}
