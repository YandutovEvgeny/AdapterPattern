using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class TemperatureC : Temperature
    {
        public TemperatureC(int t) : base(t) { }
    }
}
