using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Topic_9_12___Assignment_2.Properties;

namespace Topic_9_12___Assignment_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTemperature_Click(object sender, EventArgs e)
        {
            double temp;
            if (Double.TryParse(txtTemperature.Text, out temp))
            {
                if (temp < 0)
                {
                    imgTemperature.Image = Resources.doyouwannabuildasnowman;
                }
                else if (temp >= 0 && temp <= 25)
                {
                    imgTemperature.Image = Resources.spring;
                }
                else if (temp >= 25 && temp <= 40)
                {
                    imgTemperature.Image = Resources.misinformation;
                }
                else if (temp >= 40 && temp <= 100)
                {
                    imgTemperature.Image = Resources.shifting_sand_land;
                }
                else
                {
                    imgTemperature.Image = Resources.hell;
                }
                lblTemperature.Text = ("Current Temperature: " + Math.Round(temp, 2) + "℃");
            }
            else
            {
                imgTemperature.Image = Resources.WROOONG;
                lblTemperature.Text = "Invalid Temperature!";

            }
        }
    }
}
