using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car
{
    public class Rock : IAtkSet
    {
        public void Atk()
        {
            //使用火箭  
            MessageBox.Show("使用火箭炮攻擊");
        }
    }
}
