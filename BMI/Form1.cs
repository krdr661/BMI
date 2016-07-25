using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double value = GetBMIValue(90, 1.75);
            if (value != -1)
                MessageBox.Show(GetManResult(value));
            else
                MessageBox.Show("體重或身高不得小於0");
        }
        private double GetBMIValue(double weight, double height)
        {
            if (weight > 0 && height > 0)
                return weight / Math.Pow(height, 2);
            else
                return -1;
        }
        private string GetManResult(double bmi)
        {
            if (bmi < 20)
                return "太瘦";
            else if (bmi > 25)
                return "太胖";
            else
                return "適中";
        }
        private string GetWomanResult(double bmi)
        {
            if (bmi < 18)
                return "太瘦";
            else if (bmi > 22)
                return "太胖";
            else
                return "適中";
        }
    }
}
