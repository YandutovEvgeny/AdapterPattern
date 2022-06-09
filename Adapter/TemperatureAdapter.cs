using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class TemperatureAdapter : TemperatureC
    {
        public TemperatureAdapter(TemperatureF temp) : base(temp.T)
        {
            T = (int)((temp.T - 32) * 5.0 / 9.0); 
        }
    }
}
