using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardAdapter
{
    class FromFile
    {
        public int N { get; set; }
        public int[,] Buffer { get; private set; }
        public string path;
        public FromFile()
        {

            //Buffer = new int[N, N];
            path = "C:\\Users\\Admin\\Desktop\\FromFile.txt";
            GetText();
        }
        public int[,] GetText()
        {
            //string path = "C:\\Users\\Admin\\Desktop";
            FileStream fileStream = new FileStream(path, FileMode.OpenOrCreate);
            StreamReader streamReader = new StreamReader(fileStream);
            N = Convert.ToInt32(streamReader.ReadLine());
            Buffer = new int[N, N];

            //int[,] buffer = new int[N, N];
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Buffer[i, j] = streamReader.Read() - 48;
                }
            }
            fileStream.Close();

            return Buffer;
        }
    }
}
