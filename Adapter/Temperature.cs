using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class Temperature
    {
        public int T { get; protected set; }

        public Temperature(int t)
        {
            T = t;
        }
        public int GetT()
        {
            return T;
        }
    }
}
