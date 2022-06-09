using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardAdapter
{
    class MyArray
    {
        public int[,] Array { get; set; }
        public int N { get; set; }

        public MyArray(int n)
        {
            Array = new int[n, n];
            N = n;
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Array[i, j] = random.Next(10);
                }
            }
        }
    }
}
