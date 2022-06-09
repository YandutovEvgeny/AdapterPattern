using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class MeteoStation
    {
        TemperatureC temp;

        public MeteoStation(TemperatureC temp)
        {
            this.temp = temp;
        }
        public string Show()
        {
            return $"Температура воздуха {temp.GetT()} по Цельсию";
        }
    }
}
