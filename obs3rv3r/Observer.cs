using System;
using System.Collections.Generic;
using System.Text;

namespace obs3rv3r
{
   public  interface Observer
    {
        void update(float temp, float humidity, float pressure);

    }
}
