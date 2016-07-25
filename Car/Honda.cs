using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car
{
    public class Honda : ICar
    {
        public void Atk()
        {
            MessageBox.Show("攻擊");
        }

        public void SpeedDown()
        {
            MessageBox.Show("減速中");
        }

        public void SpeedUp()
        {
            MessageBox.Show("加速中");
        }

        public void UseItem()
        {
            MessageBox.Show("使用物品");
        }
    }
}
