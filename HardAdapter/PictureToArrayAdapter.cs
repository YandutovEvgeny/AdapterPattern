using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardAdapter
{
    class PictureToArrayAdapter : MyArray
    {
        public PictureToArrayAdapter(Picture picture) : base(picture.N)
        {
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Color color = picture.Bitmap.GetPixel(i, j);
                    if (color.R > 120)
                        Array[j, i] = 1;
                    else
                        Array[j, i] = 0;
                }
            }
        }
    }
}
