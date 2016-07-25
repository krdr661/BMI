using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Honda car1 = new Honda();
            car1.SpeedUp();
            car1.SpeedDown();
            car1.UseItem();
            car1.Atk();                        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ISpeedUpSet superspeed = new SuperHightSpeed();
            ISpeedDownSet brake = new Brake();
            IUseItemSet banana = new UseStart();
            IAtkSet rock = new Rock();
            Mazeda car2 = new Mazeda(superspeed, brake, banana, rock);
            car2.SpeedUp();
            car2.SpeedDown();
            car2.UseItem();
            car2.Atk();
        }
    }
}
