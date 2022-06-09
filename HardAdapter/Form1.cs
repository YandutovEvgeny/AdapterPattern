using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HardAdapter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GridArray gridArray = new GridArray(dataGridView1, new MyArray(10));
            gridArray.ShowInfo();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Picture picture = new Picture("C:\\Users\\Admin\\Downloads\\s.png");
            GridArray gridArray = new GridArray(dataGridView1, new PictureToArrayAdapter(picture));
            gridArray.ShowInfo();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FromFile file = new FromFile();
            GridArray gridArray = new GridArray(dataGridView1, new FromFileToArrayAdapter(file));
            gridArray.ShowInfo();
        }
    }
}
