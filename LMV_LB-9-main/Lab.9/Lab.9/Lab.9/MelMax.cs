using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab._9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = 0, b = Math.PI*6, h = 0.1, x, y;
            this.chart1.Series[0].Points.Clear();
            this.chart2.Series[0].Points.Clear();
            x = a;
            while (x <= b)
                
            {
                y = Math.Sin(x) + Math.Sin(2 * x);
                this.chart1.Series[0].Points.AddXY(x, y);
                this.chart2.Series[0].Points.AddXY(x, y);
                x += h;
            }

        }

        private void chart2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();        
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
