using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adapter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TemperatureC temperatureC = new TemperatureC(25);
            MeteoStation meteoStation = new MeteoStation(temperatureC);
            MessageBox.Show(meteoStation.Show());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TemperatureF temperatureF = new TemperatureF(100);
            MeteoStation meteoStation = new MeteoStation(new TemperatureAdapter(temperatureF));
            MessageBox.Show(meteoStation.Show());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TemperatureK temperatureK = new TemperatureK(25);
            MeteoStation meteoStation = new MeteoStation(new UniversalAdapter(temperatureK));
            MessageBox.Show(meteoStation.Show());
        }
    }
}
