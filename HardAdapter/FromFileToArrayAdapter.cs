using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardAdapter
{
    class FromFileToArrayAdapter : MyArray
    {
        public FromFileToArrayAdapter(FromFile file) : base(file.N)
        {
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Array[j, i] = file.Buffer[j, i];
                }
            }
        }
    }
}
