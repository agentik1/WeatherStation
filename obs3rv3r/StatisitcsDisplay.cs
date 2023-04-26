using System;
using System.Collections.Generic;
using System.Text;

namespace obs3rv3r
{
    class StatisitcsDisplay : Observer, DisplayElement
    {
        private float maxTemp = 0;
        private float minTemp = 200;
        private float tempSum = 0;
        private int numReadings = 0;
        private Subject weatherData;

        

        public void display()
        {
            float avgTemp = tempSum / numReadings;
            Console.WriteLine($"Statistics Avg/Max/Min temperature = {avgTemp}, {maxTemp},{minTemp}");


        }

        public void update(float temp, float humidity, float pressure)
        {
            this.tempSum += temp;
            this.numReadings += 1;

            if (temp > this.maxTemp)
            {
                this.maxTemp = temp;
            }
            else
            {
                this.minTemp = temp;

            }
        }
    }
}
