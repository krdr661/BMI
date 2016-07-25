using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maintenance
{
    public abstract class Maintenance
    {
        private void 洗臉清潔()
        {
            //洗臉.....
        }
        private void 化妝水()
        {
            //使用化妝水
        }
        protected abstract void 深層清潔();
        protected abstract void 均衡滋潤();
    }
    public class MaintA : Maintenance
    {
        protected override void 均衡滋潤()
        {
            //去角質
        }

        protected override void 深層清潔()
        {
            //均衡滋潤-塗美白精華液
        }
    }
    public class MaintB : Maintenance
    {
        protected override void 均衡滋潤()
        {
            //拔粉刺
        }

        protected override void 深層清潔()
        {
            //均衡滋潤-塗抗氧化精華液
        }
    }
}
