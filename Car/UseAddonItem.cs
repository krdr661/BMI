using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car
{
    public class UseStart : IUseItemSet
    {
        public void UseItem()
        {
            //使用香蕉
            MessageBox.Show("使用小星星無敵");
        }
    }
}
