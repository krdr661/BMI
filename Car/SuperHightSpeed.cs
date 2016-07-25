using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car
{
    public class SuperHightSpeed : ISpeedUpSet
    {
        public void SpeedUp()
        {
            //高速噴射
            MessageBox.Show("高速噴射");
        }
    }
}
