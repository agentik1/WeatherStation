using System;
using System.Collections.Generic;
using System.Text;

namespace obs3rv3r
{
    class ForecastDisplay : Observer, DisplayElement
    {
        private float currentPressure = 29.92F;
        private float lastPressure = 0;
        
        
        private Subject weatherData;
        public void display()
        {
            if (currentPressure > lastPressure)
            {
                Console.WriteLine("Improving weather on the way!");

            }
            else if(currentPressure == lastPressure)
            {
                Console.WriteLine("More of the same");
            }

            else if (currentPressure < lastPressure)
            {
                Console.WriteLine("Watch out for cooler, rainy weather");
            }
        }

        public void update(float temp, float humidity, float pressure)
        {
            this.lastPressure = this.currentPressure;
            this.currentPressure = pressure;

        }
    }
}
