using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car
{
    public class Brake : ISpeedDownSet
    {
        public void SpeedDown()
        {
            //剎車
            MessageBox.Show("剎車");
        }
    }
}
