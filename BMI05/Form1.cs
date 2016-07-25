using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Human human = new Human() { Gender = GenderType.Man, weight = 90, height = 1.75 };
            BMIAdapter adapter = new BMIAdapter(human);
            MessageBox.Show(adapter.result);
        }
    }
}
