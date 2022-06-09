using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardAdapter
{
    class Picture
    {
        public Bitmap Bitmap { get; set; }
        public int N { get; set; }
        public Picture(string path)
        {
            Bitmap = new Bitmap(path);
            N = Bitmap.Width;
        }
    }
}
