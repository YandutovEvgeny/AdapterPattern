using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class UniversalAdapter : TemperatureC
    {
        public UniversalAdapter(Temperature temperature) : base(temperature.T)
        {
            if(temperature is TemperatureF)
                T = (int)((temperature.T - 32) * 5.0 / 9.0);
            if (temperature is TemperatureC)
                T = temperature.T;
            if (temperature is TemperatureK)
                T = temperature.T - 273;
        }
    }
}
